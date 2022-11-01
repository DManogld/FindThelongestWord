using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.DirectoryServices;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;

namespace FindThelongestWord
{
    public partial class Form1 : Form
    {
  
        public Form1()
        {
            InitializeComponent();
        }

        private void InputText_TextChanged(object sender, EventArgs e)
        {
            ChooseText.Visible = false;
            buttonLongest.Visible = false;
            kuerzte.Visible = false;
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            ChooseText.Visible = true;
            buttonLongest.Visible = true;
            kuerzte.Visible = true;
        }
       

        private void kuerzte_Click(object sender, EventArgs e)
        {
            List<string> Lwords = new List<string>();
            //List<string> Twords = new List<string>();

            string Text = textBoxInput.Text;

            string[] words = Text.Split(new[] { " " }, StringSplitOptions.None);

            IEnumerable<string> query = from word in words
                                        orderby word.Length
                                        ascending
                                        select word;

            int control = 1;

            foreach (string s in query)
            {
                if (s.Length <= control)
                {
                    Lwords.Add(s);
                    control = s.Length;
                }
            }

            MessageBox.Show(string.Join(Environment.NewLine, Lwords.ToArray()));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void  buttonLongest_Click(object sender, EventArgs e)
        {

            List<string> longestWords = new List<string>();
            string[] separators = new string[] { " ", "\n", "\r", ",", ".", "" };
            string[] words = textBoxInput.Text.Split(separators, StringSplitOptions.None);

            IEnumerable<string> query = from word in words
                                        orderby word.Length                                       
                                        descending
                                        select word;

            Dictionary<string, int> duplicateWords = new Dictionary<string, int>();
            foreach (string s in query)
            {
                if (s.Length >= (longestWords.Count > 0 ? longestWords[0].Length : 0))
                {
                    longestWords.Add(s);
                    if (duplicateWords.ContainsKey(s))
                        duplicateWords[s]++;
                    else                    
                        duplicateWords.Add(s, 1);                    
                }
                else
                {
                    break;
                }
            }                     

            var newLongWord = new StringBuilder();//Using StringBuilder because easier way to join strings or append line of strings

            foreach (var item in duplicateWords) //Iterate dictionary and form a string
            {
                newLongWord.AppendLine($"{item.Key} : wird {item.Value} verwendet und hat:({item.Key.ToString().Length}) Buchstaben.");
            }

            var message = MessageBox.Show(newLongWord.ToString(), "Wollen Sie es speichern?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (message == DialogResult.Yes)
            {
                if (saveFileDialogTextfile.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialogTextfile.FileName))
                    {
                        sw.WriteLine(newLongWord.ToString());
                        sw.Flush();
                        sw.Close();
                    }
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialogTextfile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialogTextfile.FileName))
                {
                    sw.WriteLine(buttonLongest.Text);
                    sw.Flush();
                    sw.Close();
                }
            }
        }
    }
}