using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Microsoft.VisualBasic;


namespace StringProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string copied;

        Functions func = new Functions();
       

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string op = function_proc.SelectedIndex.ToString();

            int counter = 0;
            int c1 = 0, c2 = 0;

            checkEmpty(counter, c1, c2);

            if ((text.Text == "" || text.Text == null || counter == text.Text.Length || (c1 == text2.Text.Length && text2.Visible == true) || (c2 == text3.Text.Length && text3.Visible == true)) && (op != "32" && op != "34"))
            {

                MessageBox.Show("الرجاء تعبئة الحقول المطلوبة");
                res.Text = "";
            }




            else if (function_proc.Text == "" || text.Text == null || function_proc.Text == "اختر الدالة")
            {
                MessageBox.Show("الرجاء إختيار الدالة المراد تنفيذها");
                res.Text = "";
            }
            else
            {




                switch (op)
                {
                    //--------------------------------------------------------------------------------------------+
                    case "0": func.UpperFunc(text, res, explain); break;
                    //--------------------------------------------------------------------------------------------+
                    case "1": func.LowerFunc(text, res, explain); break;
                    //--------------------------------------------------------------------------------------------+
                    case "2": func.HashFunc(text, res, explain); break;
                    //--------------------------------------------------------------------------------------------+
                    case "3": func.GetTypeCode(text, res); break;
                    //--------------------------------------------------------------------------------------------+
                    case "4": func.GetType(text, res); break;
                    //--------------------------------------------------------------------------------------------+
                    case "5": func.CompareFunc(text, text2, res, explain); break;
                    //--------------------------------------------------------------------------------------------+
                    case "6": func.Substring(text, text2, text3, res); break;
                    //--------------------------------------------------------------------------------------------+
                    case "7": func.StartsWith(text, text2, res); break;
                    //--------------------------------------------------------------------------------------------+
                    case "8": func.EndsWith(text, text2, res); break;
                    //--------------------------------------------------------------------------------------------+
                    case "9": func.Contains(text, text2, res); break;
                    //--------------------------------------------------------------------------------------------+
                    case "10": func.Split(text, text2, res); break;
                    //--------------------------------------------------------------------------------------------+
                    case "11": func.Concat(text, text2, res); break;
                    //--------------------------------------------------------------------------------------------+
                    case "12": copied = func.Copy(copied, text, res); paste.Enabled = true; break;
                    //--------------------------------------------------------------------------------------------+
                    case "13": copied = func.Clone(copied, text, res); paste.Enabled = true; break;
                    //--------------------------------------------------------------------------------------------+
                    case "14": func.Insert(text, text2, text3, res); break;
                    //--------------------------------------------------------------------------------------------+
                    case "15": func.Remove(text, text2, text3, res); break;
                    //--------------------------------------------------------------------------------------------+
                    case "16": func.Replace(text, text2, text3, res); break;
                    //--------------------------------------------------------------------------------------------+
                    case "17": func.IndexOf(text, text2, res); break;
                    //--------------------------------------------------------------------------------------------+
                    case "18": func.LastIndexOf(text, text2, res); break;
                    //--------------------------------------------------------------------------------------------+
                    case "19": func.LastIndexOfAny(text, text2, res); break;
                    //--------------------------------------------------------------------------------------------+
                    case "20": func.Trim(text, res); break;
                    //--------------------------------------------------------------------------------------------+
                    case "21": func.TrimStart(text, res); break;
                    //--------------------------------------------------------------------------------------------+
                    case "22": func.TrimEnd(text, res); break;
                    //--------------------------------------------------------------------------------------------+
                    case "23": func.Length(text, res); break;
                    //--------------------------------------------------------------------------------------------+
                    case "24": func.ToCharArray(text, res); break;
                    //--------------------------------------------------------------------------------------------+
                    case "25": func.Format(text, text2, res); break;
                    //--------------------------------------------------------------------------------------------+
                    case "26": func.CompareOrdinal(text, text2, res); break;
                    //--------------------------------------------------------------------------------------------+
                    case "27": func.Equals(text, text2, res); break;
                    //--------------------------------------------------------------------------------------------+
                    case "28": func.CopyTo(text, text2, text3, res); break;
                    //--------------------------------------------------------------------------------------------+
                    case "29": func.PadLeft(text, text2, text3, res); break;
                    //--------------------------------------------------------------------------------------------+
                    case "30": func.PadRight(text, text2, text3, res); break;
                    //--------------------------------------------------------------------------------------------+
                    case "31": func.Join(text, text2, res); break;
                    //--------------------------------------------------------------------------------------------+
                    case "32": func.IsNE(text, res); break;
                    //--------------------------------------------------------------------------------------------+
                    case "33": func.Intern(text, text2, res); break;
                    //--------------------------------------------------------------------------------------------+
                    case "34": func.IsNW(text, res); break;
                    //--------------------------------------------------------------------------------------------+
                    case "35": func.isInterned(text, res); break;
                    //--------------------------------------------------------------------------------------------+
                    case "36": func.isNormalized(text, res); break;
                    //--------------------------------------------------------------------------------------------+
                    case "37": func.Normalize(text, res); break;

                }


            }
        }

        private void function_proc_SelectedIndexChanged(object sender, EventArgs e)
        {

            string index = function_proc.SelectedIndex.ToString();

            func.ClearAll(text2, text3, res);

            switch (index)
            {

                case "0":
                    func.showExplain(explain, " تقوم هذه الدالة بتحويل النص من الاحرف الانجليزية (small) الى الاحرف الانجليزية (capital).");
                    func.HideAll(text2, text3, input_label2, input_label3);
                    break;
                case "1":
                    func.showExplain(explain, "تقوم هذه الدالة بتحويل النص من الاحرف الانجليزية (capital) الى الاحرف الانجليزية (small).");
                    func.HideAll(text2, text3, input_label2, input_label3);
                    break;
                case "2":
                    func.showExplain(explain, "تستقبل هذه الدالة  parameter من نوع string   وتقوم هذه الدالة بإرجاع رقم يميز هذا العنصر ويختلف باختلاف محتوى هذا العنصر");
                    func.ClearAll(text2, text3, res);
                    func.HideAll(text2, text3, input_label2, input_label3);
                    break;

                case "3":
                    func.showExplain(explain, "اذا كانت البيانات المدخلة من  نوع  سلسلة  نصية  String  فان الدالة ترجع   كلمة  String  مما يدل على ان البيانات المدخلة  من نوع  String اما اذا كانت البيانات المدخلة  منطقية  أي من نوع  Boolean  فان الدالة ترجع  true or false");
                    func.HideAll(text2, text3, input_label2, input_label3);
                    break;

                case "4":
                    func.showExplain(explain, "تعيد الدالة نوع النص من اي كائن");
                    func.HideAll(text2, text3, input_label2, input_label3);
                    break;

                case "5":
                    func.showExplain(explain, "تقو هذه الدالة بمقارنة النصوص وترجع القيمة صفر عند تطابق النصين وإرجاع القيمة 1 عند عدم تطابق النصين ، وسنقوم باستغلال القيمة الراجعة اذا كانت تساوي 1 سنقوم بطباعة النص مطابق واذا كانت تساوي صفر سنقوم بطباعة النص غير مطابق.");
                    func.ShowOne(text2, text3, input_label2, input_label3);
                    func.InitVal(text2, input_label2, text3, input_label3, "مطابقه مع :");
                    break;
                //--------------------------------------------------------------------------------------------+
                case "6":
                    func.showExplain(explain, "تقوم هذة الدالة باقتصاص السلسلة ، حيث يجب تحديد بداية السلسلة وعدد الاحرف او يمكن تحديد بداية السلسلة ويتم قص النص إبتداءً برقم بداية السلسلة وانتهاءً بنهاية طول النص");
                    func.ShowAll(text2, text3, input_label2, input_label3);
                    input_label2.Text = "البداية :";
                    input_label2.Location = new Point(199, 25);
                    text2.Width = 40;
                    text2.Location = new Point(153, 23);
                    input_label3.Text = "عدد الاحرف :";
                    input_label3.Location = new Point(199, 70);
                    text3.Width = 40;
                    text3.Location = new Point(153, 68);
                    break;

                //--------------------------------------------------------------------------------------------+
                case "7":
                    func.showExplain(explain, "دالة تستخدم لمقارنة قيمة مع بداية سلسلةاو مقارنة الاحرف الاولى من سلسلة ضد سلسلة اخرى ، والدالة تأخد معامل من نوع String وهي سلسلة المقارنة . وتعيد دالة قيمة منطقية True اذا تطابقت القيمة مع بداية السلسلة و تعيد False في حالة لم تتطابق.");
                    func.ShowOne(text2, text3, input_label2, input_label3);
                    func.InitVal(text2, input_label2, text3, input_label3, "مطابقه مع :");
                    break;
                //--------------------------------------------------------------------------------------------+
                case "8":
                    func.showExplain(explain, "دالة تستخدم لمقارنة قيمة مع نهاية سلسلةاو مقارنة الاحرف الاخيره من سلسلة ضد سلسلة اخرى ، والدالة تأخد معامل من نوع String وهي سلسلة المقارنة . وتعيد دالة قيمة منطقية True اذا تطابقت القيمة مع نهاية السلسلة و تعيد False في حالة لم تتطابق.");
                    func.ShowOne(text2, text3, input_label2, input_label3);
                    func.InitVal(text2, input_label2, text3, input_label3, "مطابقه مع :");
                    break;
                //--------------------------------------------------------------------------------------------+
                case "9":
                    func.showExplain(explain, "تعيد قيمة منطقية إذا كانت السلسة النصية تحتوي على النص الذي تم إدخاله أم لا وأيضا البحث هل يحتوي النص على النص المعطى أم لا");
                    func.ShowOne(text2, text3, input_label2, input_label3);
                    func.InitVal(text2, input_label2, text3, input_label3, "مطابقه مع :");
                    ; break;
                //--------------------------------------------------------------------------------------------+
                case "10":
                    func.showExplain(explain, "دالة تستخدم لتقطيع سلسلة نصية الى كلمات، والدالة تأخد معامل واحد وهو الفاصل الذي يتم الاقتصاص من بعده. الفاصل قد يكون حرف او مصفوفة فارغة او فراغ ، وتعيد  مصفوفة تحتوي عناصرها على subStrings() التي يتم تحديدها بواسطة حرف او اكثر في فاصل .ملاحظة: عندما يتم تحديد سلسلة بواسطة مجموعة معروفة من الاحرف يمكن استخدام طريقة split(char[])");
                    func.ShowOne(text2, text3, input_label2, input_label3);
                    func.InitVal(text2, input_label2, text3, input_label3, "الفاصل :", 40, 245, 28);
                    break;
                //--------------------------------------------------------------------------------------------+
                case "11":
                    func.showExplain(explain, "دالة تعمل على دمج نصين في نص واحد");
                    func.ShowOne(text2, text3, input_label2, input_label3);
                    func.InitVal(text2, input_label2, text3, input_label3, "دمج مع :");
                    break;
                //--------------------------------------------------------------------------------------------+
                case "12":
                    func.showExplain(explain, "دالة تقوم بنسخ النص الى متغير نصي ، بعد ذلك يمكنك عمل طباعه له او معالجه");
                    break;
                //--------------------------------------------------------------------------------------------+
                case "13": func.showExplain(explain, "تقوم بإنشاء وإرجاع نسخه من كائن السلسلة");
                    break;
                //--------------------------------------------------------------------------------------------+
                case "14":
                    func.showExplain(explain, "يتم استخدامه لإرجاع سلسلة جديدة يتم فيها إدراج سلسلة محددة في موقع محدد.");
                    func.ShowAll(text2, text3, input_label2, input_label3);
                    input_label2.Text = "الموقع :";
                    input_label2.Location = new Point(298, 27);
                    text2.Width = 40;
                    text2.Location = new Point(245, 24);
                    input_label3.Text = "النص :";
                    input_label3.Location = new Point(295, 71);
                    text3.Width = 165;
                    text3.Location = new Point(120, 69); break;
                //--------------------------------------------------------------------------------------------+
                case "15":
                    func.showExplain(explain, "تقوم بإلغاء حرف او مجموعة أحرف من النص ، وهي مفيدة لتقصير السلاسل او لحذف الفراغات . وتعمل الدالة باكثر من طريقه إما بحذف نص إبتداءا من موقع محدد او او بحذف مجموعة أحرف محصوره بين حرفين");
                    func.ShowAll(text2, text3, input_label2, input_label3);
                    input_label2.Text = "حرف البداية / موقع البداية :";
                    input_label2.Location = new Point(200, 27);
                    text2.Width = 40;
                    text2.Location = new Point(156, 24);
                    input_label3.Text = "الحرف الأخير :";
                    input_label3.Location = new Point(200, 71);
                    text3.Width = 40;
                    text3.Location = new Point(156, 69); break;
                //--------------------------------------------------------------------------------------------+
                case "16":
                    func.showExplain(explain, "تعمل على إستبدل النصوص او الأحرف ، وتعمل بطريقتين : إما إستبدل حرف من النص بحرف اخر أو إستبدل نص بنص اخر");
                    func.ShowAll(text2, text3, input_label2, input_label3);
                    input_label2.Text = "(إستبدل) الحرف / النص :";
                    input_label2.Location = new Point(200, 27);
                    text2.Width = 100;
                    text2.Location = new Point(98, 24);
                    input_label3.Text = "(ب) الحرف / النص :";
                    input_label3.Location = new Point(200, 71);
                    text3.Width = 100;
                    text3.Location = new Point(98, 69); break;
                //--------------------------------------------------------------------------------------------+
                case "17":
                    func.showExplain(explain, "تقوم بالبحث عن نص محدد او حرف ، وتستقبل الدالة عدة قيم منها حرف او نص . حيث نقوم بنمرير النص او الحرف الى الدالة فتقوم بارجاع اول موقع للحرف او النص المطابق وفي حال عدم وجود تطابق ترجع القيمة -1");
                    func.ShowOne(text2, text3, input_label2, input_label3);
                    func.InitVal(text2, input_label2, text3, input_label3, "الحرف / النص :");
                    input_label2.Location = new Point(275, 24);
                    text2.Width = 207;
                    text2.Location = new Point(62, 19);
                    break;
                //--------------------------------------------------------------------------------------------+
                case "18":
                    func.showExplain(explain, "تعمل على البحث عن اخر موقع للحرف او النص المدخل وفي حال التطابق تعيد الداله موقع الحرف وفي حالة عدم التطابق تعيد الدالة القيمه -1");
                    func.ShowOne(text2, text3, input_label2, input_label3);
                    func.InitVal(text2, input_label2, text3, input_label3, "الحرف / النص :");
                    input_label2.Location = new Point(275, 24);
                    text2.Width = 207;
                    text2.Location = new Point(62, 19);
                    break;
                //--------------------------------------------------------------------------------------------+
                case "19":
                    func.showExplain(explain, "تعمل على البحث عن اخر موقع للحرف او النص المدخل وتستقبل الدالة مصفوفه من نوع Char وفي حال كان المدخل حرف يتم القيام بعملية البحث والمطابقه واذا كان الحرف موجود تعيد موقع الحرف واذا كان الحرف موجود اكثر من مره تعيد اخر موقع للحرف، اما اذا كان المدخل المراد البحث عنه عباره عن نص يتم مقارنه الحرف الاول مع النص الاصلي وفي حاله تطابق اول حرف من النص مع النص الاصلي تعيد موقع الحرف واذا لما يطابق الحرف الاول يتم فحص الحرف التالي وهكذا  وعند عدم التطابق تعيد الدالة القيمه -1");
                    func.ShowOne(text2, text3, input_label2, input_label3);
                    func.InitVal(text2, input_label2, text3, input_label3, "الحرف / النص :");
                    input_label2.Location = new Point(275, 24);
                    text2.Width = 207;
                    text2.Location = new Point(62, 19);
                    break;
                //--------------------------------------------------------------------------------------------+
                case "20":
                    func.showExplain(explain, "تعمل على إقتصاص الفراغات من الجهة اليمنى واليسرى");
                    func.HideAll(text2, text3, input_label2, input_label3); break;
                //--------------------------------------------------------------------------------------------+
                case "21":
                    func.showExplain(explain, "تعمل على إقتصاص الفراغات من البداية");
                    func.HideAll(text2, text3, input_label2, input_label3); break;
                //--------------------------------------------------------------------------------------------+
                case "22":
                    func.showExplain(explain, "تعمل على إقتصاص الفراغات من النهاية");
                    func.HideAll(text2, text3, input_label2, input_label3); break;
                //--------------------------------------------------------------------------------------------+
                case "23":
                    func.showExplain(explain, "هي عباره عن خاصية وليست دالة ، و تعمل على حساب طول النص المدخل حيث يتم بدء العد من 1");
                    func.HideAll(text2, text3, input_label2, input_label3); break;
                //--------------------------------------------------------------------------------------------+
                case "24":
                    func.showExplain(explain, "تعمل على تحويل النص المدخل الى مصفوفة من نوع Char");
                    func.HideAll(text2, text3, input_label2, input_label3); break;
                //--------------------------------------------------------------------------------------------+
                case "25":
                    func.showExplain(explain, "يتم إستبدال كائن من نوع نص بنص اخر من اختيارك وتعيد الدالة النص بعد الإستبدال");
                    func.InitVal(text2, input_label2, text3, input_label3, "إستبدل بـ :");
                    break;
                //--------------------------------------------------------------------------------------------+
                case "26":
                    func.showExplain(explain, "تعمل على مقارنة نصين وتعيد قيمه اكبر من الصفر في حال كان الحرف الاول من النص الاول اكبر من الحرف الاول في النص الاخر من حيث Unicode وتعيد قيمه اقل من الصفر في حال حدوث العكس");
                    func.InitVal(text2, input_label2, text3, input_label3, "مقارنه بـ :");
                    break;
                //--------------------------------------------------------------------------------------------+
                case "27":
                    func.showExplain(explain, "تقوم هذه الدالة بمقارنة النصوص وترجع القيمة True عند تطابق النصين وإرجاع القيمة False عند عدم تطابق النصين ، وسنقوم باستغلال القيمة الراجعة اذا كانت تساوي True سنقوم بطباعة النص مطابق واذا كانت تساوي False سنقوم بطباعة النص غير مطابق.");
                    func.ShowOne(text2, text3, input_label2, input_label3);
                    func.InitVal(text2, input_label2, text3, input_label3, "مقارنه بـ :");
                    break;
                //--------------------------------------------------------------------------------------------+
                case "28":
                    func.showExplain(explain, "تعمل على نسخ نص وإستبداله بـ مجموعه احرف داخل مصفوفة حرفية  مع تحديد موقع البداية للنص داخل للمصفوفة");
                    func.ShowAll(text2, text3, input_label2, input_label3);
                    input_label2.Text = "النص :";
                    input_label2.Location = new Point(275, 24);
                    text2.Width = 190;
                    text2.Location = new Point(79, 19);
                    input_label3.Text = "موقع البداية :";
                    input_label3.Location = new Point(280, 70);
                    text3.Width = 51;
                    text3.Location = new Point(220, 68);
                    break;

                //--------------------------------------------------------------------------------------------+
                case "29":
                    func.showExplain(explain, "تعمل على إزاحة النص لليسار بعدد محدد وترك باقي المساحة بحرف معين");
                    func.ShowAll(text2, text3, input_label2, input_label3);
                    input_label2.Text = "مقدار الازاحة :";
                    input_label2.Location = new Point(275, 24);
                    text2.Width = 100;
                    text2.Location = new Point(170, 19);
                    input_label3.Text = "الحرف :";
                    input_label3.Location = new Point(290, 70);
                    text3.Width = 51;
                    text3.Location = new Point(230, 68);
                    break;

                //--------------------------------------------------------------------------------------------+
                case "30":
                    func.showExplain(explain, "تعمل على إزاحة النص لليمين بعدد محدد وترك باقي المساحة بحرف معين");
                    func.ShowAll(text2, text3, input_label2, input_label3);
                    input_label2.Text = "مقدار الازاحة :";
                    input_label2.Location = new Point(275, 24);
                    text2.Width = 100;
                    text2.Location = new Point(170, 19);
                    input_label3.Text = "الحرف :";
                    input_label3.Location = new Point(290, 70);
                    text3.Width = 51;
                    text3.Location = new Point(230, 68);
                    break;

                //--------------------------------------------------------------------------------------------+
                case "31":
                    func.showExplain(explain, "تعمل على تجميع نص مقسم على سبيل المثال لو كان لدينا مصفوفه من 3 عناصر واسندنا لكل عنصر قيمه ونريد ان نظهر كل عناصرها اي نريد تجميع هذه العناصر لاظهارها في رساله او لوضعها في متغير اخر او ايضا لدمج هذه العناصر مع نص اخر");
                    func.ShowOne(text2, text3, input_label2, input_label3);
                    func.InitVal(text2, input_label2, text3, input_label3, "النص :");
                    break;
                //--------------------------------------------------------------------------------------------+
                case "32":
                    func.showExplain(explain, "تعمل على فحص النص اذا كان  خالياً Null او فارغاً وتعيد القيمه True اذا كان النص فارغاً وتعيد القيمه False في حال لم يكن فارغاً");
                    func.HideAll(text2, text3, input_label2, input_label3);
                    break;
                //--------------------------------------------------------------------------------------------+
                case "33":
                    func.showExplain(explain, "إذا كان لدينا متغير نصي لديه قيمه ماخوذه من متغير آخر فانه يعتر ذو مصدر غير نقي وعندما نقوم باسناد قيمه متغير نصي للمتغير النصي السابق فان المتغير النتاج يكون قيمه نقيه بعكس المتغير السابق اي ان الداله قامت بدمج النصين في المتغير وجعلها ك مرجع واحد");
                    func.ShowOne(text2, text3, input_label2, input_label3);
                    func.InitVal(text2, input_label2, text3, input_label3, "النص :");
                    break;
                //--------------------------------------------------------------------------------------------+
                case "34":
                    func.showExplain(explain, "تفحص ما اذا كان النص فارغاً او فراغات وتعيد قيمه منطقيه True اذا تحقق الشرط مالم تعيد القيمه False");
                    func.HideAll(text2, text3, input_label2, input_label3);
                    break;
                //--------------------------------------------------------------------------------------------+
                case "35":
                    func.showExplain(explain, "باستخدام الأسلوب string.IsInterned، يمكنك اختبار ما إذا كانت سلسلة موجودة في الجدول الداخلي، دون إضافته");
                    func.HideAll(text2, text3, input_label2, input_label3);
                    break;
                //--------------------------------------------------------------------------------------------+
                case "36":
                    func.showExplain(explain, "في السلاسل الفريدة يوجد العديد من الاشكال التطبيعيات التي تحدد كيفية تمثيل حرف معين مع هذه الدالة نستطيع اختبار تطبيع بيانات الحروف");
                    func.HideAll(text2, text3, input_label2, input_label3);
                    break;
                //--------------------------------------------------------------------------------------------+
                case "37":
                    func.showExplain(explain, "تقوم هذه الداله بالتحقق اذا كانت السلسلة في نموذج تطبيع Unicode ام لا . والناتج من هذه الداله هو قيمه منطقية");
                    func.HideAll(text2, text3, input_label2, input_label3);
                    break;
                //--------------------------------------------------------------------------------------------+
                case "38":
                    func.showExplain(explain, "من اهم دوال السلاسل الحرفية واكثرها إستخداماً ، وهي تعمل على تحويل الارقام او القيم المنطقية الى نصوص");
                    func.HideAll(text2, text3, input_label2, input_label3);
                    break;

            }
        }

        private void about_label_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-ابراهيم عبدالله -احمد العواضي - حمزه العباسي  - فاخر الحاج- مالك الربيد\n - محمد قمحان - أمين الصوفي- انس بجاش  -  خديجة الحميدي \n- صلاح الشامي - أكرم البنا  \n فتحي جميل  - سند خالد", " إعداد الطلاب", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }





        private void button1_Click_3(object sender, EventArgs e)
        {
            if (label2.Visible == true && explain.Visible == true)
            {
                label2.Visible = false;
                explain.Visible = false;
                groupBox1.Location = new Point(50, 255);
                explain_button.Location = new Point(184, 188);
                do_it.Location = new Point(356, 187);
                explain_button.Text = "إظهار شرح الدالة";
            }

            else
            {

                label2.Visible = true;
                explain.Visible = true;
                groupBox1.Location = new Point(50, 347);
                explain_button.Location = new Point(50, 192);
                do_it.Location = new Point(356, 137);
                explain_button.Text = "إخفاء شرح الدالة";

            }

        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            res.Text = text.Text.IndexOf("za").ToString();

        }

        private void لصقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveControl.Text = ActiveControl.Text + this.copied;

        }



        private void text_TextChanged(object sender, EventArgs e)
        {

        }

        private void function_proc_Click(object sender, EventArgs e)
        {

        }



        public void checkEmpty(int counter, int c1, int c2)
        {
            for (int i = 0; i < text.Text.Length; i++)
            {
                if (text.Text[i] == ' ')
                    counter++;
            }



            if (text2.Visible == true)
            {
                for (int i = 0; i < text2.Text.Length; i++)
                {
                    if (text2.Text[i] == ' ')
                        c1++;
                }
            }

            if (text3.Visible == true)
            {
                for (int i = 0; i < text3.Text.Length; i++)
                {
                    if (text3.Text[i] == ' ')
                        c2++;
                }
            }

        }

    }
}
