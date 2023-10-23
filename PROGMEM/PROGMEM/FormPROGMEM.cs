using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.IO.Compression;
using System;
using PROGMEM.Common;
using System.IO;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace PROGMEM
{
    public partial class FormPROGMEM : Form
    {
        byte[] dataInput;
        List<string> dataStringOutput;
        string stringOutput;

        #region ctor

        public FormPROGMEM()
        {
            InitializeComponent();

            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            Initialize();
        }

        private void Initialize()
        {
            dataInput = new byte[0];
            dataStringOutput = new List<string>();

            btnProgmemArrayWork.Click += (s, e) => DoWork();

            btnLoadInputData.Click += (s, e) => OpenFile();
            btnClearInputData.Click += (s, e) => ClearInputData();
            btnSaveFile.Click += (s, e) => SaveFile();
        }

        #endregion


        #region events buttons

        private void OpenFile()
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Title = "Browse files";

                ofd.DefaultExt = "txt";
                ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                ofd.FilterIndex = 2;
                ofd.RestoreDirectory = true;

                ofd.ReadOnlyChecked = true;
                ofd.ShowReadOnly = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    LoadInputData(ofd.FileName);
                }
            };
        }

        private void LoadInputData(string filePath)
        {
            dataInput = File.ReadAllBytes(filePath);
            RefreshTextBoxDataInput();
        }

        private void SaveFile()
        {
            if (dataStringOutput.Count == 0 && stringOutput.Length == 0)
                return;

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.DefaultExt = "txt";
                sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.FilterIndex = 2;
                sfd.RestoreDirectory = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    SaveOutputData(sfd.FileName);
                }
            }
        }

        private void SaveOutputData(string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                if (rbEncode.Checked)
                {
                    int poz = 0;

                    var count = dataStringOutput.Count;

                    foreach (var item in dataStringOutput)
                    {
                        sw.Write(item);

                        if (poz != count - 1)
                            sw.Write(", ");

                        if ((poz + 1) % 10 == 0)
                            sw.Write(Environment.NewLine);

                        poz++;
                    }
                }
                else if (rbDecode.Checked)
                {
                    sw.Write(stringOutput);
                }

                sw.Close();
            }
        }

        private void ClearInputData()
        {
            dataInput = new byte[0];

            RefreshTextBoxDataInput();
        }

        #endregion


        #region logic

        private void DoWork()
        {
            try
            {
                if (rbEncode.Checked)
                    ProgmemArrayEncode();
                else if (rbDecode.Checked)
                    ProgmemArrayDecode();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void ProgmemArrayEncode()
        {
            dataStringOutput.Clear();

            var input = dataInput;

            if (cbGZip.Checked)
            {
                var compressData = GZip.CompressBytes(input);

                input = compressData;
            }

            foreach (var data in input)
            {
                dataStringOutput.Add($@"0x{data.ToString("X").PadLeft(2, '0')}");
            }

            RefreshTextBoxDataOutputEncode();
        }

        private void ProgmemArrayDecode()
        {
            dataStringOutput.Clear();
            stringOutput = string.Empty;

            var str = System.Text.UTF8Encoding.Default.GetString(dataInput);

            var splitData = str.Split(',');
            splitData = splitData.Select(x => x.Trim()).Select(x => x.ToUpper()).ToArray();


            var pattern = @"^0X[0-9A-F]{2,2}$";
            Regex rg = new Regex(pattern);
            foreach (var item in splitData)
            {
                if (!rg.Match(item).Success)
                {
                    MessageBox.Show($@"Not valid {item}");
                    return;
                }
            }

            List<byte> input = new List<byte>();
            foreach (var item in splitData)
            {
                var data = item.Substring(2);

                input.Add(byte.Parse(data, System.Globalization.NumberStyles.HexNumber));
            }


            if (cbGZip.Checked)
            {
                var decompressData = GZip.DecompressBytes(input.ToArray());

                input = decompressData.ToList();
            }

            stringOutput = System.Text.UTF8Encoding.Default.GetString(input.ToArray());


            RefreshTextBoxDataOutputDecode();
        }

        private void RefreshTextBoxDataInput()
        {
            rtDataInput.Text = Encoding.UTF8.GetString(dataInput);
            RefreshDataInputLength();
        }

        private void RefreshDataInputLength()
        {
            teDataInputLength.Text = dataInput.Length.ToString();
        }

        private void RefreshTextBoxDataOutputEncode()
        {
            rtDataOutput.Text = string.Join(", ", dataStringOutput);
            RefreshDataOutputEncodeLength();
        }

        private void RefreshDataOutputEncodeLength()
        {
            teDataOutputLength.Text = dataStringOutput.Count.ToString();
        }

        private void RefreshTextBoxDataOutputDecode()
        {
            rtDataOutput.Text = stringOutput;
            RefreshDataOutputDecodeLength();
        }

        private void RefreshDataOutputDecodeLength()
        {
            teDataOutputLength.Text = rtDataOutput.Text.Length.ToString();
        }

        #endregion
    }
}