using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StringProject
{
    class Functions
    {

        public void UpperFunc(TextBox txt, TextBox res, TextBox explain)
        {

                res.Text = txt.Text.ToUpper();


        }

        public void LowerFunc(TextBox txt, TextBox res, TextBox explain)
        {

                res.Text = txt.Text.ToLower();

        }

        public void HashFunc(TextBox txt, TextBox res, TextBox explain)
        {
            int hash = txt.Text.GetHashCode();
            res.Text = hash.ToString();

        }

        public void CompareFunc(TextBox txt1, TextBox txt2, TextBox res, TextBox explain)
        {


            int result = txt1.Text.CompareTo(txt2.Text);

                if (result == 0){
                res.ForeColor = Color.Blue;
                res.Text = "( "+result+" )"+" النص متطابق تماماً ";
            }

            else
            {
                res.ForeColor = Color.Red;
                res.Text = "( " + result + " )" + " النص غير متطابق ";
            }


        }

        public void Substring(TextBox txt1,TextBox txt2,TextBox txt3,TextBox res)
        {
            try
            {


                if (txt2.Text == "")
                    res.Text = txt1.Text.Substring(int.Parse(txt3.Text));
                else
                    res.Text = txt1.Text.Substring(int.Parse(txt2.Text), int.Parse(txt3.Text));


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void Insert(TextBox txt1, TextBox txt2, TextBox txt3, TextBox res)
        {

            try
            {


                res.Text = txt1.Text.Insert(int.Parse(txt2.Text), txt3.Text);


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
               


        }


        public void StartsWith(TextBox txt1,TextBox txt2,TextBox res)
        {

            bool result = txt1.Text.StartsWith(txt2.Text);


                if (result == true)
                {
                    res.ForeColor = Color.Blue;
                    res.Text = " ( " + result.ToString() + " ) " + "مطابق مع بداية النص ";

                }

                else
                {
                    res.ForeColor = Color.Red;
                    res.Text = " ( " + result.ToString() + " ) " + "غير مطابق مع بداية النص";
                }
            }
        

        public void EndsWith(TextBox txt1, TextBox txt2, TextBox res)
        {

            bool result = txt1.Text.EndsWith(txt2.Text);


                if (result == true)
                {
                    res.ForeColor = Color.Blue;
                    res.Text = " ( " + result.ToString() + " ) " + "مطابق مع نهاية النص ";

                }

                else
                {
                    res.ForeColor = Color.Red;
                    res.Text = " ( " + result.ToString() + " ) " + "غير مطابق مع نهاية النص";
                }
            
        }

        public void Contains(TextBox txt1, TextBox txt2, TextBox res)
        {


            bool result = txt1.Text.Contains(txt2.Text);


                if (result == true)
                {
                    res.ForeColor = Color.Blue;
                    res.Text = " ( " + result.ToString() + " ) " + "النص موجود ";

                }

                else
                {
                    res.ForeColor = Color.Red;
                    res.Text = " ( " + result.ToString() + " ) " + "النص غير موجود";
                }
            
        }

        public void Remove(TextBox txt1, TextBox txt2, TextBox txt3, TextBox res)
        {
            try
            {
                char f = txt2.Text[0];
                char l = txt3.Text[0];
                int index1 = txt1.Text.IndexOf(f);
                int index2 = txt1.Text.IndexOf(l);
                res.Text = txt1.Text.Remove(index1, index2);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            }

        public void Replace(TextBox txt1, TextBox txt2, TextBox txt3, TextBox res)
        {

                
                try
                {

                    res.Text = txt1.Text.Replace(txt2.Text, txt3.Text);

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

        }
        


        public void Split(TextBox txt, TextBox txt2,TextBox res)
        {

            Program.split = txt.Text.Split(txt2.Text[0]);

           Sub sb = new Sub(1);
          sb.ShowDialog();
        }

        public void ToCharArray(TextBox txt, TextBox res)
        {
            
          
            Program.char_array = txt.Text.ToCharArray();
            Sub sb = new Sub(2);
            sb.ShowDialog();
           
        }

        public void Concat(TextBox txt1,TextBox txt2, TextBox res)
        {
            res.Text = String.Concat(txt1.Text, txt2.Text);
        }

        public void IndexOf(TextBox txt1, TextBox txt2, TextBox res)
        {
            try
            {
                int result = txt1.Text.IndexOf(txt2.Text);
                if (result >= 0)
                {
                    res.ForeColor = Color.Blue;
                    res.Text = txt1.Text.IndexOf(txt2.Text).ToString();
                }
                else
                {
                    res.ForeColor = Color.Red;
                    res.Text = "( " + result.ToString() + " ) " + " النص او الحرف غير موجود";
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void LastIndexOf(TextBox txt1, TextBox txt2, TextBox res)
        {
            try
            {


                int result = txt1.Text.LastIndexOf(txt2.Text);
                if (result >= 0)
                {
                    res.ForeColor = Color.Blue;
                    res.Text = txt1.Text.LastIndexOf(txt2.Text).ToString();
                }
                else
                {
                    res.ForeColor = Color.Red;
                    res.Text = "( " + result.ToString() + " ) " + " النص او الحرف غير موجود";
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void LastIndexOfAny(TextBox txt1, TextBox txt2, TextBox res)
        {
            try
            {

                char[] arr = txt2.Text.ToCharArray();
                int result = txt1.Text.LastIndexOfAny(arr);
                if (result >= 0)
                {
                    res.ForeColor = Color.Blue;
                    res.Text = txt1.Text.LastIndexOfAny(arr).ToString();
                }
                else
                {
                    res.ForeColor = Color.Red;
                    res.Text = "( " + result.ToString() + " ) " + " النص او الحرف غير موجود";
                }



            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public string Copy(string copied,TextBox txt,TextBox res)
        {
            copied = String.Copy(txt.Text);
            MessageBox.Show("تمت عملية النسخ بنجاح ..قم بالنقر بزر الماوس الايمن في اي مربع نص لكي تقوم بعملية اللصق");
            return copied;
            
        }
        public string Clone(string copied, TextBox txt, TextBox res)
        {
            copied = (String)txt.Text.Clone();
            MessageBox.Show("تمت عملية النسخ بنجاح ..قم بالنقر بزر الماوس الايمن في اي مربع نص لكي تقوم بعملية اللصق");
            return copied;
        }

        public void Trim(TextBox txt, TextBox res)
        {

            res.Text = txt.Text.Trim();

        }


        public void GetTypeCode(TextBox txt, TextBox res)
        {

            res.Text = txt.Text.GetTypeCode().ToString();

        }

        public void GetType(TextBox txt, TextBox res)
        {

            res.Text = txt.Text.GetType().ToString();

        }

        public void TrimStart(TextBox txt, TextBox res)
        {

            res.Text = txt.Text.TrimStart();

        }

        public void TrimEnd(TextBox txt, TextBox res)
        {

            res.Text = txt.Text.TrimEnd();

        }

        public void Length(TextBox txt, TextBox res)
        {

            res.Text = "طول النص هو ( " + txt.Text.Length.ToString() + " ) ";
            

        }


        public void Format(TextBox txt1,TextBox txt2,TextBox res)
        {
            Object ob = txt1.Text;
            res.Text = string.Format(txt2.Text, ob);


        }

        public void CompareOrdinal(TextBox txt1,TextBox txt2,TextBox res)
        {
            int result = String.CompareOrdinal(txt1.Text, txt2.Text);

            if (result > 0)
            {
                res.Text = "الحرف الاول بالنص الاول اكبر ";
            }
            else
            {
                res.Text = res.Text = "الحرف الاول بالنص الثاني اكبر ";
            }
        }

        public void Equals(TextBox txt1, TextBox txt2, TextBox res)
        {
           

            bool result = txt1.Text.Equals(txt2.Text);


            if (result == true)
            {
                res.ForeColor = Color.Blue;
                res.Text = "( " + result + " )" + " النص متطابق تماماً ";
            }

            else
            {
                res.ForeColor = Color.Red;
                res.Text = "( " + result + " )" + " النص غير متطابق ";
            }


        }

        public void CopyTo(TextBox txt1, TextBox txt2, TextBox txt3,TextBox res)
        {

            res.Clear();
           
            char [] array = txt1.Text.ToCharArray();
            txt2.Text.CopyTo(0, array, int.Parse(txt3.Text),txt2.Text.Length);

            for (int i = 0; i < array.Length; i++)
                res.Text += array[i].ToString();

        }


        public void PadLeft(TextBox txt1, TextBox txt2, TextBox txt3, TextBox res)
        {

            res.Text = txt1.Text.PadLeft(int.Parse(txt2.Text), txt3.Text[0]);

        }


        public void PadRight(TextBox txt1, TextBox txt2, TextBox txt3, TextBox res)
        {

            res.Text = txt1.Text.PadRight(int.Parse(txt2.Text), txt3.Text[0]);

        }

        public void Join(TextBox txt1, TextBox txt2,TextBox res)
        {
            string[] arr = txt1.Text.Split(' ');

            res.Text = String.Join(txt2.Text, arr);

        }

        public void Intern(TextBox txt1, TextBox txt2, TextBox res)
        {

            txt2.Text = String.Intern(txt1.Text);
            res.Text = txt2.Text;

        }

        public void IsNE(TextBox txt1,TextBox res)
        {
            bool result = String.IsNullOrEmpty(txt1.Text);


            if (result == true)
            {
                res.ForeColor = Color.Blue;
                res.Text = "( " + result + " )" + " النص خالياً  ";
            }

            else
            {
                res.ForeColor = Color.Red;
                res.Text = "( " + result + " )" + " النص ليس خالياً ";
            }

        }

        public void IsNW(TextBox txt1,TextBox res)
        {


            bool result = String.IsNullOrWhiteSpace(txt1.Text);


            if (result == true)
            {
                res.ForeColor = Color.Blue;
                res.Text = "( " + result + " )" + " النص خالي او فراغ ";
            }

            else
            {
                res.ForeColor = Color.Red;
                res.Text = "( " + result + " )" + " النص غير غير خالي ";
            }


        }


        public void isInterned(TextBox txt1, TextBox res)
        {


            bool result = String.IsInterned(txt1.Text) != null;
            
            

            if (result == true)
            {
                res.ForeColor = Color.Blue;
                res.Text = "( " + result + " )" ;
            }

            else
            {
                res.ForeColor = Color.Red;
                res.Text = "( " + result + " )" ;
            }


        }


        public void isNormalized(TextBox txt1, TextBox res)
        {


            bool result = txt1.Text.IsNormalized();



            if (result == true)
            {
                res.ForeColor = Color.Blue;
                res.Text = "( " + result + " )";
            }

            else
            {
                res.ForeColor = Color.Red;
                res.Text = "( " + result + " )";
            }


        }


        public void Normalize(TextBox txt1, TextBox res)
        {


            bool result = txt1.Text.Normalize() != null;

            if (result == true)
            {
                res.ForeColor = Color.Blue;
                res.Text = "( " + result + " )";
            }

            else
            {
                res.ForeColor = Color.Red;
                res.Text = "( " + result + " )";
            }


        }

        public void showExplain(TextBox explain,string val)

        {
            
            explain.Text = val;

        }

        public void ClearAll(TextBox text1, TextBox text2, TextBox res)
        {
            text1.Clear();
            text2.Clear();
            res.Clear();
            res.ForeColor = Color.Blue;

        }

        public void InitVal(TextBox text, Label lab, TextBox text2, Label lab2, string val)
        {
            lab.Text = val;
            lab.Location = new Point(298, 32);
            text.Width = 258;
            text.Location = new Point(28, 30);
            lab2.Visible = false;
            text2.Visible = false;
        }

        public void InitVal(TextBox text, Label lab, TextBox text2, Label lab2, string val, int width, int p1, int p2)
        {
            lab.Text = val;
            lab.Location = new Point(298, 32);
            text.Width = width;
            text.Location = new Point(p1, p2);
            lab2.Visible = false;
            text2.Visible = false;
        }

        public void HideAll(TextBox text1, TextBox text2, Label lab1, Label lab2)
        {
            text1.Visible = false;
            text2.Visible = false;
            lab1.Visible = false;
            lab2.Visible = false;
        }

        public void ShowAll(TextBox text1, TextBox text2, Label lab1, Label lab2)
        {
            text1.Visible = true;
            text2.Visible = true;
            lab1.Visible = true;
            lab2.Visible = true;
        }

        public void ShowOne(TextBox text1, TextBox text2, Label lab1, Label lab2)
        {
            text1.Visible = true;
            text2.Visible = false;
            lab1.Visible = true;
            lab2.Visible = false;
        }


    }
}
