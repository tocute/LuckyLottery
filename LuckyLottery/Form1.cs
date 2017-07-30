using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace LuckyLottery
{
    public partial class Form1 : Form
    {
        ArrayList mRawData = new ArrayList();
        ArrayList mQuestResult = new ArrayList();
        String mFilePath = Application.StartupPath + @"\666.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime this_day = DateTime.Today;
            _TbMonth.Text = this_day.Month.ToString();
            _TbDay.Text = this_day.Day.ToString();
        }

        private void ReadFileBtn_Click(object sender, EventArgs e)
        {
            _LvRawData.Items.Clear();
            mRawData.Clear();

            _LvResultData.Items.Clear();
            mQuestResult.Clear();

            string line = "";

            // Read the file and display it line by line.
            StreamReader sr = new StreamReader(mFilePath);
            while ((line = sr.ReadLine()) != null)
            {
                char[] delimiterChars = { ' ' };
                string[] words = line.Split(delimiterChars);
                mRawData.Add(words);
            }

            sr.Close();

            if (mRawData.Count > 0)
            {
                // UI Setting
                DisplayListView(_LvRawData, mRawData, _RbSize.Checked);
                _LvRawData.Items[_LvRawData.Items.Count - 1].EnsureVisible();

                // Enable button
                _BtnQuery.Enabled = true;
                _BtnSaveFile.Enabled = false;
                _BtnDeleteItem.Enabled = true;
                _BtnColored.Enabled = false;
                _BtnDecrease.Enabled = false;
                _BtnIncrease.Enabled = false;
            }
        }

        private void SaveFileBtn_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(mFilePath);
            for (int i = 0; i < mRawData.Count; i++)
            {
                string[] words = (string[])mRawData[i];
                string line = words[0] + " " + words[1] + " " + words[2] + " " + words[3] + " " + words[4] + " " + words[5] + " " + words[6] + " " + words[7] + " " + words[8];
                sw.WriteLine(line);
            }
            sw.Close();
        }

        private void _BtnDeleteItem_Click(object sender, EventArgs e)
        {
            if (_LvRawData.SelectedItems.Count > 0)
            {
                int deleted_index = _LvRawData.SelectedItems[0].Index;
                if (deleted_index > -1)
                {
                    _LvRawData.Items.RemoveAt(deleted_index);
                    mRawData.RemoveAt(deleted_index);
                    _BtnSaveFile.Enabled = true;
                }
            }
        }

        private void QueryBtn_Click(object sender, EventArgs e)
        {
            if (_TbNumOne.Text != "" && _TbNumTwo.Text != "" && _TbNumThree.Text != "")
            { 
                _LvResultData.Items.Clear();
                mQuestResult.Clear();

                int list_size = mRawData.Count;
                int [] statistics = new int [50];
                for (int i = 0; i < statistics.Length; i++)
                    statistics[i] = 0;

                for (int i = 0; i < list_size; i++)
                {
                    int[] num_data = new int [7];
                    string[] words2 = (string[])mRawData[i];
                    for (int j = 0; j < num_data.Length; j++)
                    {
                        num_data[j] = Convert.ToInt32(words2[j+2]);
                    }

                    //тㄢ计常Τ瞷魁
                    if (Array.IndexOf(num_data, Convert.ToInt32(_TbNumOne.Text)) != -1 && Array.IndexOf(num_data,  Convert.ToInt32(_TbNumTwo.Text)) != -1)
                    {
                        int down_count = Convert.ToInt32(_TbNumThree.Text);
                        if (down_count + i < list_size)
                        {
                            string[] words = (string[])mRawData[i + down_count];
                            mQuestResult.Add(words);

                            for (int j = 2; j < 9; j++)
                            {
                                int index = Int32.Parse(words[j]);
                                statistics[index]++;
                            }
                        }
                    }
                }

                //find max 2
                int major_index = -1;
                int major_value = 0;
                for (int i = 0; i < statistics.Length; i++)
                {
                    if (major_value < statistics[i])
                    {
                        major_value = statistics[i];
                        major_index = i;
                    }
                }

                int minor_index = -1;
                int minor_value = 0;
                for (int i = 0; i < statistics.Length; i++)
                {
                    if (minor_value < statistics[i] && i != major_index)
                    {
                        minor_value = statistics[i];
                        minor_index = i;
                    }
                }

                // UI Setting
                DisplayListView(_LvResultData, mQuestResult, _RbSize.Checked);
                _BtnColored.Enabled = true;
                _BtnDecrease.Enabled = true;
                _BtnIncrease.Enabled = true;

                _LbResultDescr.Text = "计 " + _TbNumOne.Text + "  计 " + _TbNumTwo.Text + "\n┕计" + _TbNumThree.Text+"";
                _LbResultPredict.Text = _LvResultData.Items.Count.ToString() + "Ωい瞷程玡ㄢ\n" + 
                    major_index.ToString() + "瞷 " + major_value.ToString() + "Ω\n" + 
                    minor_index.ToString() + "瞷 " + minor_value.ToString() + "Ω";
            }
        }

        private void ColoredBtn_Click(object sender, EventArgs e)
        {
            if (_TbColoredNum.Text != "")
            { 
                for (int i = 0; i < _LvResultData.Items.Count; i++)
                {
                    ListViewItem item = _LvResultData.Items[i];
                    for(int j=2; j<8; j++)
                    {
                        int color_num = Convert.ToInt32(_TbColoredNum.Text);
                        int search_num = Convert.ToInt32(item.SubItems[j].Text);

                        if (color_num == search_num)
                        {
                            item.SubItems[j].BackColor = Color.Orange;
                        }
                        else
                        {
                            item.SubItems[j].BackColor = Color.White;
                        }
                    }
                }
            }
        }

        private void AddRecordBtn_Click(object sender, EventArgs e)
        {
            if( _TbMonth.Text != "" && _TbDay.Text != "" && 
                _TbNewNum1.Text != "" && _TbNewNum2.Text != "" && _TbNewNum3.Text != "" && 
                _TbNewNum4.Text != "" && _TbNewNum5.Text != "" && _TbNewNum6.Text != "" && 
                _TbNewNum7.Text != "")
            {
                string[] words = { 
                    AddZoreForStr(_TbMonth.Text),
                    AddZoreForStr(_TbDay.Text),
                    AddZoreForStr(_TbNewNum1.Text),
                    AddZoreForStr(_TbNewNum2.Text),
                    AddZoreForStr(_TbNewNum3.Text),
                    AddZoreForStr(_TbNewNum4.Text),
                    AddZoreForStr(_TbNewNum5.Text),
                    AddZoreForStr(_TbNewNum6.Text),
                    AddZoreForStr(_TbNewNum7.Text)
                };

                mRawData.Add(words);

                ListViewItem lvi = new ListViewItem(words[0]);
                lvi.SubItems.Add(words[1]);
                lvi.SubItems.Add(words[2]);
                lvi.SubItems.Add(words[3]);
                lvi.SubItems.Add(words[4]);
                lvi.SubItems.Add(words[5]);
                lvi.SubItems.Add(words[6]);
                lvi.SubItems.Add(words[7]);
                lvi.SubItems.Add(words[8]);

                lvi.UseItemStyleForSubItems = false;
                lvi.SubItems[0].BackColor = Color.Yellow;
                lvi.SubItems[1].BackColor = Color.Yellow;
                lvi.SubItems[8].BackColor = Color.LightGreen;
                _LvRawData.Items.Add(lvi);

                _BtnSaveFile.Enabled = true;
            }
        }

        /////////////////////////////// add / minus Button
        private void _BtnDecrease_Click(object sender, EventArgs e)
        {
            int num1 =  Convert.ToInt32(_TbNumOne.Text);
            int num2 =  Convert.ToInt32(_TbNumTwo.Text);
            int down_count = Convert.ToInt32(_TbNumThree.Text);
            if (down_count > 1 && _LvResultData.Items.Count > 0)
            { 
                int new_num3 = down_count - 1;
                _TbNumThree.Text = new_num3.ToString();
                QueryBtn_Click(null, null);
            }

        }

        private void _BtnIncrease_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(_TbNumOne.Text);
            int num2 = Convert.ToInt32(_TbNumTwo.Text);
            int down_count = Convert.ToInt32(_TbNumThree.Text);
            if (_LvResultData.Items.Count > 0)
            {
                int new_num3 = down_count + 1;
                _TbNumThree.Text = new_num3.ToString();
                QueryBtn_Click(null, null);
            }
        }

        /////////////////////////////// Radio Button
        private void _RbOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (_LvRawData.Items.Count > 0)
            {
                DisplayListView(_LvRawData, mRawData, false);
                _LvRawData.Items[_LvRawData.Items.Count - 1].EnsureVisible();
            }

            if (_LvResultData.Items.Count > 0)
            {
                DisplayListView(_LvResultData, mQuestResult, false);
            }
        }

        private void _RbSize_CheckedChanged(object sender, EventArgs e)
        {
            if (_LvRawData.Items.Count > 0)
            {
                DisplayListView(_LvRawData, mRawData, true);
                _LvRawData.Items[_LvRawData.Items.Count - 1].EnsureVisible();
            }

            if (_LvResultData.Items.Count > 0)
            {
                DisplayListView(_LvResultData, mQuestResult, true);
            }
        }

        ///////////////////////////////  User Function
        private string AddZoreForStr(string str)
        {
            int num = Convert.ToInt32(str);
            if (num < 10)
                return "0" + str;
            else
                return str;
        }

        private void DisplayListView(ListView lW, ArrayList rawData, bool by_size)
        {
            lW.Items.Clear();
            for (int i = 0; i < rawData.Count; i++)
            {
                string[] old_words = (string[])rawData[i];
                string[] words = (string[])old_words.Clone();
 
                if (by_size)
                {
                    string[] num_data = new List<string>(words).GetRange(2, 6).ToArray();
                    Array.Sort(num_data, StringComparer.InvariantCulture);
                    for (int j = 2; j < 8; j++)
                    {
                        words[j] = num_data[j - 2];
                    }
                }

                ListViewItem lvi = new ListViewItem(words[0]);

                lvi.SubItems.Add(words[1]);
                lvi.SubItems.Add(words[2]);
                lvi.SubItems.Add(words[3]);
                lvi.SubItems.Add(words[4]);
                lvi.SubItems.Add(words[5]);
                lvi.SubItems.Add(words[6]);
                lvi.SubItems.Add(words[7]);
                lvi.SubItems.Add(words[8]);

                lvi.UseItemStyleForSubItems = false;
                lvi.SubItems[0].BackColor = Color.Yellow;
                lvi.SubItems[1].BackColor = Color.Yellow;
                lvi.SubItems[8].BackColor = Color.LightGreen;

                lW.Items.Add(lvi);
            }
        }
    }
}