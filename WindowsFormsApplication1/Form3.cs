using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            label1.Text = Form2.name;
        }
        int[] x = new int[10]; //for check random question repeat
        bool qchange = false, Aud = false; //for lifeline1 and 2
        bool s; //Random fuction
        bool fifty = false; //for 50/50
        public static int score = 0;
        public static int Noofcorrect = 0;
        public int second = 0, qid = 1;
        public int count = 0, check = 0; //count for question and check for array index
        public string[] question = new string[22];
        public string[] optionA = new string[22];
        public string[] optionB = new string[22];
        public string[] optionC = new string[22];
        public string[] optionD = new string[22];
        public string[] correctOptions = new string[22];
        SoundPlayer questionscreen = new SoundPlayer(@"whole question.wav");
        SoundPlayer correctop = new SoundPlayer(@"rightselection_cut.wav");
        public SoundPlayer wrongselect = new SoundPlayer(@"wrong click.wav");
        private void Form3_Load(object sender, EventArgs e)
        {
            questionscreen.Play();
            score1.BackColor = Color.Yellow;

            //setting Timer Intervel;
            timer1.Interval = 1000;
            timer1.Start();
            if (Form2.expert == true)
            {
                #region Question_For_Experts
                question[0] = "Which Of The Following Statements Applies To The Situation Where Exception Is Not Handled In The Program:";
                optionA[0] = "CLR will terminate the program execution at the point it encounters an exception.";
                optionB[0] = "CLR will not show any output. However, the code will execute successfully.";
                optionC[0] = "World war Web";
                optionD[0] = "Wrong Wood Web";
                correctOptions[0] = optionA[0];

                question[1] = "Which of the following unary operators can be overloaded?\n1-true\n2-false\n3- +\n4- new\n5- is";
                optionA[1] = "1, 2, 3";
                optionB[1] = "3, 4, 5";
                optionC[1] = "3 only";
                optionD[1] = "The Code executes successfully and an error message gets printed.";
                correctOptions[1] = optionB[1];

                question[2] = "A derived class can stop virtual inheritance by declaring an override as";
                optionA[2] = "Extends";
                optionB[2] = "Sealed";
                optionC[2] = "Locked";
                optionD[2] = "Override";
                correctOptions[2] = optionB[2];

                question[3] = "Which of the following keyword is used to change the data and behavior of a base class by replacing a member of a base class with a new derived member?";
                optionA[3] = "new";
                optionB[3] = "base";
                optionC[3] = "override";
                optionD[3] = "Virtual";
                correctOptions[3] = optionA[3];

                question[4] = "Which of the following keyword is used to overload user-defined types by defining static member functions?";
                optionA[4] = "op";
                optionB[4] = "opoverload";
                optionC[4] = "operator";
                optionD[4] = "operatoroverload";
                correctOptions[4] = optionC[4];

                question[5] = "Which of the followings is the correct way to overload + operator?";
                optionA[5] = "public sample operator+(sample a,sample b)";
                optionB[5] = "public abstract operator+(sample a,sample b)";
                optionC[5] = "public abstract sample operator+(sample a,sample b)";
                optionD[5] = "public static sample operator+(sample a,sample b)";
                correctOptions[5] = optionD[5];

                question[6] = "Which of the following statements are correct?\n1-All operators in C#.NET can be overloaded.\n2- We can use the new modifier to modify a nested type if the nested type is hiding another type.\n3- In case of operator overloading all parameters must be of the different type than the class or struct that declares the operator.\n4- Method overloading is used to create several methods with the same name that performs similar tasks on similar data types.\n5- Operator overloading permits the use of symbols to represent computations for a type.";
                optionA[6] = "1,3";
                optionB[6] = "2,4";
                optionC[6] = "2,5";
                optionD[6] = "3,4";
                correctOptions[6] = optionC[6];

                question[7] = "Which of the following operators cannot be overloaded?\n1-true\n2-false\n3-new\n4- ~\n5-sizeof";
                optionA[7] = "1,3";
                optionB[7] = "2,4";
                optionC[7] = "3,5";
                optionD[7] = "All of the Above";
                correctOptions[7] = optionC[7];

                question[8] = "Which of the following can be declared as a virtual in a class?\n1-Methods\n2-Properties\n3-Events\n4-Fields\n5-Static fields";
                optionA[8] = "1, 2, 3";
                optionB[8] = "3,5";
                optionC[8] = "2,4";
                optionD[8] = "2,3,5";
                correctOptions[8] = optionA[8];

                question[9] = "Which of the following modifier is used when a virtual method is redefined by a derived class?";
                optionA[9] = "overloads";
                optionB[9] = "override";
                optionC[9] = "virtual";
                optionD[9] = "base";
                correctOptions[9] = optionB[9];

                question[10] = "In order for an instance of a derived class to completely take over a class member from a base class, the base class has to declare that member as";
                optionA[10] = "new";
                optionB[10] = "base";
                optionC[10] = "virtual";
                optionD[10] = "override";
                correctOptions[10] = optionC[10];

                question[11] = "Which of the following are necessary for Run-time Polymorphism?\n1-The overridden base method must be virtual, abstract or override.\n2- Both the override method and the virtual method must have the same access level modifier.\n3- An override declaration can change the accessibility of the virtual method.\n4- An abstract inherited property cannot be overridden in a derived class.\n5- An abstract method is implicitly a virtual method.";
                optionA[11] = "1,3";
                optionB[11] = "1,2,5";
                optionC[11] = "2,3,4";
                optionD[11] = "4 only";
                correctOptions[11] = optionB[11];

                question[12] = "Which of the following statements is correct about the C#.NET code snippet given below?\nclass Student s1, s2; // Here 'Student' is a user-defined class.\ns1 = new Student(); \ns2 = new Student();";
                optionA[12] = "Contents of s1 and s2 will be exactly same.";
                optionB[12] = "The two objects will get created on the stack.";
                optionC[12] = "Contents of the two objects created will be exactly same.";
                optionD[12] = "The two objects will always be created in adjacent memory locations.";
                correctOptions[12] = optionC[12];

                question[13] = "Which of the following statements is correct about the C#.NET code snippet given below?\nclass Sample{\nprivate int i;\npublic Single j;\nprivate void DisplayData(){\nConsole.WriteLine(i + ' ' + j);}\npublic void ShowData(){\nConsole.WriteLine(i + ' ' + j);}\n}";
                optionA[13] = "j cannot be declared as public.";
                optionB[13] = "DisplayData() cannot be declared as private.";
                optionC[13] = "DisplayData() cannot access j.";
                optionD[13] = "There is no error in this class.";
                correctOptions[13] = optionD[13];

                question[14] = "Which of the following statements are correct?\n1-Instance members of a class can be accessed only through an object of that class.\n2-A class can contain only instance data and instance member function.\n3-All objects created from a class will occupy equal number of bytes in memory.\n4-A class can contain Friend functions.\n5-A class is a blueprint or a template according to which objects are created.";
                optionA[14] = "1,3,5";
                optionB[14] = "2,4";
                optionC[14] = "3,5";
                optionD[14] = "2,4,5";
                correctOptions[14] = optionA[14];

                question[15] = "Which of the following is the correct way to create an object of the class Sample?\nSample s = new Sample();\nSample s;\nSample s; s = new Sample();\ns = new Sample();";
                optionA[15] = "1,3";
                optionB[15] = "2,4";
                optionC[15] = "1,2,3";
                optionD[15] = "1,4";
                correctOptions[15] = optionA[15];

                question[16] = "Which of the following statements are correct?\n1-Data members ofa class are by default public.\n2-Data members of a class are by default private.\n3-Member functions of a class are by default public.\n4-A private function of a class can access a public function within the same class.\n5-Member function of a class are by default private.";
                optionA[16] = "1,3,5";
                optionB[16] = "1,4";
                optionC[16] = "2,4,5";
                optionD[16] = "1,2,3";
                correctOptions[16] = optionC[16];

                question[17] = "Which of the following statements are correct about the C#.NET code snippet given below?\nsample c;\nc = new sample();\n1-It will create an object called sample.\n2-It will create a nameless object of the type sample.\n3-It will create an object of the type sample on the stack.\n4-It will create a reference c on the stack and an object of the type sample on the heap.\n5-It will create an object of the type sample either on the heap or on the stack depending on the size of the object.";
                optionA[17] = "1,3";
                optionB[17] = "2,4";
                optionC[17] = "3,5";
                optionD[17] = "4,5";
                correctOptions[17] = optionB[17];

                question[18] = "Which of the following statements is correct about the C#.NET code snippet given below?\nint i;\nint j = new int();\ni = 10;\nj = 20; \nString str; \nstr = i.ToString(); \nstr = j.ToString();";
                optionA[18] = "This is a perfectly workable code snippet.";
                optionB[18] = "Since int is a primitive, we cannot use new with it.";
                optionC[18] = "Since an int is a primitive, we cannot call the method ToString() using it.";
                optionD[18] = "i will get created on stack, whereas j will get created on heap.";
                correctOptions[18] = optionA[18];

                question[19] = "Which of the following statements are correct about the this reference?\n1-this reference can be modified in the instance member function of a class.\n2-Static functions of a class never receive the this reference.\n3-Instance member functions of a class always receive a this reference.\n4-this reference continues to exist even after control returns from an instance member function.\n5-While calling an instance member function we are not required to pass the this reference explicitly.";
                optionA[19] = "1,4";
                optionB[19] = "2,3,5";
                optionC[19] = "3,4";
                optionD[19] = "2,5";
                correctOptions[19] = optionB[19];

                question[20] = "Which of the following statements is correct about classes and objects in C#.NET?";
                optionA[20] = "Class is a value type.";
                optionB[20] = "Since objects are typically big in size, they are created on the stack.";
                optionC[20] = "Objects of smaller size are created on the heap.";
                optionD[20] = "Objects are always nameless.";
                correctOptions[20] = optionD[20];

                question[21] = "Which one of the following Best defines a class";
                optionA[21] = "Parents of an object";
                optionB[21] = "Instance of an object";
                optionC[21] = "Scope Of an Object";
                optionD[21] = "All of the Above";
                correctOptions[21] = optionB[21];
                #endregion
            }
            else 
            {
                #region Question_For_Beginner
                question[0] = "C# Application Runs on";
                optionA[0] = "on the .Net Framework";
                optionB[0] = "using java";
                optionC[0] = "only on linux";
                optionD[0] = "None of the above option";
                correctOptions[0] = optionA[0];

                question[1] = "Which one is Not part of the .Net FrameWork";
                optionA[1] = ".Net FrameWork Class Library";
                optionB[1] = "Common Language Runtime";
                optionC[1] = "Operating System";
                optionD[1] = "None of the above";
                correctOptions[1] = optionC[1];

                question[2] = "Which is valid C# variable name";
                optionA[2] = "Bad_var";
                optionB[2] = "@Personname";
                optionC[2] = "1star";
                optionD[2] = "star.";
                correctOptions[2] = optionA[2];

                question[3] = "Fill in the Blanks With correct choices\n________a = false;\ndouble p = 4.22;\n____ c = 'Hi';\nint d =11;";
                optionA[3] = "bool,string";
                optionB[3] = "int,bool";
                optionC[3] = "bool,char";
                optionD[3] = "double,string";
                correctOptions[3] = optionA[3];

                question[4] = "What is the name of the IDE used to create C# Programs";
                optionA[4] = "3D Studio";
                optionB[4] = "Visual Maya";
                optionC[4] = "CStudio";
                optionD[4] = "Visual Studio";
                correctOptions[4] = optionD[4];

                question[5] = "Every Console application in C# should contains";
                optionA[5] = "Main Method";
                optionB[5] = "variables";
                optionC[5] = "input-output";
                optionD[5] = "All of the above";
                correctOptions[5] = optionA[5];

                question[6] = "Which type of Application uses a text only interface";
                optionA[6] = "Mobile Application";
                optionB[6] = "Windows Form";
                optionC[6] = "Console Application";
                optionD[6] = "Andriod application";
                correctOptions[6] = optionC[6];

                question[7] = "What is the output of this code\nint a = 4;\nint b = 2;\nConsole.Write(a);\nConsole.Write();";
                optionA[7] = "24";
                optionB[7] = "2";
                optionC[7] = "42";
                optionD[7] = "4";
                correctOptions[7] = optionC[7];

                question[8] = "what is the type of the temp variable?\nvar temp = 14.55;";
                optionA[8] = "integer";
                optionB[8] = "Boolean";
                optionC[8] = "Double";
                optionD[8] = "String";
                correctOptions[8] = optionC[8];

                question[9] = "What is the output of this Code?\nvar n;\nn = = true;\nConsole.WriteLine(n);";
                optionA[9] = "Error";
                optionB[9] = "true";
                optionC[9] = "1";
                optionD[9] = "0";
                correctOptions[9] = optionA[9];

                question[10] = "What is the output of this code?\nint x =16;\nint y =5;\nConsole.WriteLine(x/y);";
                optionA[10] = "3.2";
                optionB[10] = "Runtime Error";
                optionC[10] = "Compile Time Error";
                optionD[10] = "3";
                correctOptions[10] = optionD[10];

                question[11] = "Which operator is used to determine the remainder";
                optionA[11] = "%";
                optionB[11] = "-";
                optionC[11] = "!";
                optionD[11] = "*";
                correctOptions[11] = optionA[11];

                question[12] = "What is the Output of following code\nint x = 6;\nx++;\nConsole.WriteLine(++x);";
                optionA[12] = "7";
                optionB[12] = "6";
                optionC[12] = "8";
                optionD[12] = "5";
                correctOptions[12] = optionC[12];

                question[13] = "What is the difference B/W ++x and x++?\n1-++x uses x's value before incrementing it\n2-++x increaments x's value before using it\n3-x++ uses x's value value then increments it\n4-x++ increments x's value before using it";
                optionA[13] = "1,3";
                optionB[13] = "2,4";
                optionC[13] = "1,4";
                optionD[13] = "2,3";
                correctOptions[13] = optionA[13];

                question[14] = "What is the output of this code?\nint a =4;\nint b = 6;\nb=a++;\nConsole.Write(++b);";
                optionA[14] = "4";
                optionB[14] = "5";
                optionC[14] = "6";
                optionD[14] = "7";
                correctOptions[14] = optionB[14];

                question[15] = "What is the output of this code?\nint x = 15;\nint y = 6;\nx %= y;\nConsole.WriteLine(x);";
                optionA[15] = "15";
                optionB[15] = "3";
                optionC[15] = "2.5";
                optionD[15] = "6";
                correctOptions[15] = optionB[15];

                question[16] = "Predict the output for the following set of code.\nstatic void Main(string[] args)\n{\nfloat a = 16.4f;\nint b = 12;\nfloat c;\nc =  a * ( b + a) / (a - b) ;\nConsole.WriteLine('result is :' +c);\nConsole.ReadLine();\n}";
                optionA[16] = "106";
                optionB[16] = "104.789";
                optionC[16] = "105.8546";
                optionD[16] = "103.45";
                correctOptions[16] = optionC[16];

                question[17] = "";
                optionA[17] = "";
                optionB[17] = "";
                optionC[17] = "";
                optionD[17] = "";
                correctOptions[17] = optionB[17];

                question[18] = "Predict the solution for the following set of code.\nstatic void Main(string[] args)\n{\nint a, b, c, x;\na = 90;\nb = 15;\nc = 3;\nx = a - b / 3 + c * 2 - 1;\nConsole.WriteLine(x);\nConsole.ReadLine();\n}";
                optionA[18] = "92";
                optionB[18] = "90";
                optionC[18] = "89";
                optionD[18] = "88";
                correctOptions[18] = optionB[18];

                question[19] = "Correct order of priorities are";
                optionA[19] = "‘/’ > ‘%’ > ‘*’ > ‘+’";
                optionB[19] = "‘/’ > ‘*’ > ‘%’ > ‘+’";
                optionC[19] = "‘*’ > ‘/’ > ‘%’ > ‘+’";
                optionD[19] = "‘%’ > ‘*’ > ‘/’ > ‘+’";
                correctOptions[19] = optionC[19];

                question[20] = "int i, j = 1, k;\nfor (i = 0; i < 3; i++)\n{\nk = j++ - ++j;\nConsole.Write(k + ' ');\n}";
                optionA[20] = "-4 -3 -2";
                optionB[20] = "-6 -4 -1";
                optionC[20] = " -2 -2 -2";
                optionD[20] = " -4 -4 -4";
                correctOptions[20] = optionC[20];

                question[21] = "10. The correct way of incrementing the operators are :";
                optionA[21] = "++ a ++";
                optionB[21] = "b ++ 1";
                optionC[21] = "c += 1";
                optionD[21] = " d =+ 1";
                correctOptions[21] = optionD[21];
                #endregion
            }
            //First Question
            Random r = new Random();
            count = r.Next(0, 22);
            x[check] = count;
            //MessageBox.Show("ques id "+qid+" count "+count+" int value "+x[check]+"check value "+check);
            label2.Text = question[count];
            label3.Text = optionA[count];
            label4.Text = optionB[count];
            label5.Text = optionC[count];
            label6.Text = optionD[count];
            label7.Text = "Question No " + qid + "";
            button1.Visible = false;
            Cash.Text = "Welcome";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Enabling Everthing we Disabled in label event 
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            correctop.Stop();
            questionscreen.Play();
            qid++;
        button1:
            if (qid <= 10)
            {
                Random r = new Random();
                count = r.Next(0, 22);
                s = search(x, count);

                if (s == true)
                {
                    goto button1;
                }
                else
                {
                    check++;
                    x[check] = count;
                    //MessageBox.Show("ques id " + qid + " count " + count + " int value " + x[check] + "check value " + check);
                    questioncheck();
                    Cash.Text = "Your Score is : " + Form3.score;

                }
            }
            //lifeline 1 control
            if (fifty == true)
            {
                pictureBox1.Enabled = false;
                pictureBox1.Image = Image.FromFile(@"Resources\fif.jpg");
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();

            }
            //lifeline 2 control
            if (qchange == true)
            {
                pictureBox2.Enabled = false;
                pictureBox2.Image = Image.FromFile(@"Resources\111KBC1 copy.jpg");
            }
            //Audience Poll Lifeline control
            if (Aud == true)
            {
                chart1.Visible = false;
                pictureBox3.Enabled = false;
                pictureBox3.Image = Image.FromFile(@"Resources\images1.png");
            }

            //after all answer correct
            if (qid == 11)
            {
                questionscreen.Stop();
                score10.BackColor = Color.Transparent;
                this.Hide();
                Form6 f6 = new Form6();
                f6.Show();
            } 
        }

        private void label3_Click(object sender, EventArgs e)
        {
             questionscreen.Stop();
            timer1.Stop();
            if (label3.Text == correctOptions[count])
            {
                Noofcorrect++;
                score = score + 10;
                pictureBox4.Visible = true;
                correctop.Play();
                label3.ForeColor = Color.Green;
                button1.Visible = true;
            }
            else
            {
                pictureBox5.Visible = true;
                wrongselect.Play();
                label3.ForeColor = Color.Red;
                button1.Visible = true;
            }
            //in case of label click we disalabled all lifelines and all lablels here
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
            label6.Enabled = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            questionscreen.Stop();
            timer1.Stop();
            if (label4.Text == correctOptions[count])
            {
                Noofcorrect++;
                score = score + 10;
                pictureBox4.Visible = true;
                correctop.Play();
                label4.ForeColor = Color.Green;
                button1.Visible = true;
            }
            else
            {
                pictureBox5.Visible = true;
                wrongselect.Play();
                label4.ForeColor = Color.Red;
                button1.Visible = true;
            }
            //in case of label click we disalabled all lifelines and all lablels here
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
            label6.Enabled = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            questionscreen.Stop();
            timer1.Stop();
            if (label5.Text == correctOptions[count])
            {
                Noofcorrect++;
                score = score + 10;
                pictureBox4.Visible = true;
                correctop.Play();
                label5.ForeColor = Color.Green;
                button1.Visible = true;
            }
            else
            {
                pictureBox5.Visible = true;
                wrongselect.Play();
                label5.ForeColor = Color.Red;
                button1.Visible = true;
            }
            //in case of label click we disalabled all lifelines and all lablels here
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
            label6.Enabled = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            questionscreen.Stop();
            timer1.Stop();
            if (label6.Text == correctOptions[count])
            {
                Noofcorrect++;
                score = score + 10;
                pictureBox4.Visible = true;
                correctop.Play();
                label6.ForeColor = Color.Green;
                button1.Visible = true;
            }
            else
            {
                pictureBox5.Visible = true;
                wrongselect.Play();
                label6.ForeColor = Color.Red;
                button1.Visible = true;
                
            }
            //in case of label click we disalabled all lifelines and all lablels here
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
            label6.Enabled = false;
        }

        public void questioncheck()
        {
            if (button1.Visible == true && qid >= 1 && qid <= 10)
            {
                //if (label2.Text.Length > 300)
                //{
                //    label2.Font = new Font(label2.Font.FontFamily, 6.3f, label2.Font.Style);
                //}
                //else if (label2.Text.Length > 350)
                //{
                //    label2.Font = new Font(label2.Font.FontFamily, 5.3f, label2.Font.Style);
                //}
                //else
                //{
                //    label2.Font = new Font(label2.Font.FontFamily, 16f, label2.Font.Style);
                //}
                second = 0;
                timer1.Start();
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label2.Text = question[count];
                label3.Text = optionA[count];
                label4.Text = optionB[count];
                label5.Text = optionC[count];
                label6.Text = optionD[count];
                label7.Text = "Question No " + qid + "";
                colorcheck();
                button1.Visible = false;
            }
        }
        public void colorcheck()
        {
            if (Noofcorrect == 0)
            {
                score1.BackColor = Color.Yellow;
            }
            if (Noofcorrect == 1)
            {
                score1.BackColor = Color.Transparent;
                score2.BackColor = Color.Yellow;
            }
            else if (Noofcorrect == 2)
            {
                score2.BackColor = Color.Transparent;
                score3.BackColor = Color.Yellow;
            }
            else if (Noofcorrect == 3)
            {
                score3.BackColor = Color.Transparent;
                score4.BackColor = Color.Yellow;
            }
            else if (Noofcorrect == 4)
            {
                score4.BackColor = Color.Transparent;
                score5.BackColor = Color.Yellow;
            }
            else if (Noofcorrect == 5)
            {
                score5.BackColor = Color.Transparent;
                score6.BackColor = Color.Yellow;
            }
            else if (Noofcorrect == 6)
            {
                score6.BackColor = Color.Transparent;
                score7.BackColor = Color.Yellow;
            }
            else if (Noofcorrect == 7)
            {
                score7.BackColor = Color.Transparent;
                score8.BackColor = Color.Yellow;
            }
            else if (Noofcorrect == 8)
            {
                score8.BackColor = Color.Transparent;
                score9.BackColor = Color.Yellow;
            }
            else if (Noofcorrect == 9)
            {
                score9.BackColor = Color.Transparent;
                score10.BackColor = Color.Yellow;
            }
            
        }
        //Random Fuction Question Check
        public bool search(int[] x, int s)
        {
            bool c = false;
            for (int i = 0; i < x.Length; i++)
            {
                if (s == x[i])
                {
                    c = true;
                    break;
                }
            }
            return c;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            fifty = true;
            pictureBox1.Enabled = false;
            if (label3.Text == correctOptions[count])
            {
                label4.Hide();
                label5.Hide();
            }
            else if (label4.Text == correctOptions[count])
            {
                label3.Hide();
                label6.Hide();
            }
            else if (label5.Text == correctOptions[count])
            {
                label3.Hide();
                label6.Hide();
            }
            else if (label6.Text == correctOptions[count])
            {
                label4.Hide();
                label5.Hide();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            pictureBox2.Enabled = false;
            if (fifty == true || Aud == true)
            {
                chart1.Visible = false;
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
            }
        button1:
            Random r = new Random();
            count = r.Next(0, 22);
            s = search(x, count);

            if (s == true)
            {
                goto button1;
            }
            else
            {

                x[check] = count;
                //MessageBox.Show("ques id " + qid + " count " + count + " int value " + x[check] + "check value " + check);
                button1.Visible = true;
                questioncheck();
            }
            questionscreen.Play();
            qchange = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (Aud == true)
            {
                return;

            }
            else
            {


                chart1.Visible = true;
                Random r = new Random();
                string CORRECTOP = correctOptions[count], a = label3.Text, b = label4.Text, c = label5.Text, d = label6.Text;
                int ai = 0, bi = 0, ci = 0, di = 0;

                if (CORRECTOP.Equals(a) == true)
                {
                    ai = 65;
                    bi = r.Next(1, 20);
                    ci = 30 - bi;
                    di = 100 - (ai + bi + ci);

                }

                if (CORRECTOP.Equals(b) == true)
                {
                    bi = 65;
                    ai = r.Next(1, 20);
                    ci = 30 - ai;
                    di = 100 - (ai + bi + ci);

                }

                if (CORRECTOP.Equals(c) == true)
                {
                    ci = 65;
                    bi = r.Next(1, 20);
                    ai = 30 - bi;
                    di = 100 - (ai + bi + ci);

                }

                if (CORRECTOP.Equals(d) == true)
                {
                    di = 65;
                    bi = r.Next(1, 20);
                    ci = 30 - bi;
                    ai = 100 - (di + bi + ci);

                }


                //AddXY value in chart1 in series named as Audiance  
                chart1.Series["AudiencePoll"].Points.AddXY("A", (ai).ToString());
                chart1.Series["AudiencePoll"].Points.AddXY("B", (bi).ToString());
                chart1.Series["AudiencePoll"].Points.AddXY("C", (ci).ToString());
                chart1.Series["AudiencePoll"].Points.AddXY("D", (di).ToString());

                //chart title  
                chart1.Titles.Add("Audiance Chart");
                Aud = true;
            }﻿
        }

        private void label8_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            questionscreen.Stop();
            Form6 f6 = new Form6();
            this.Hide();
            f6.Show();      
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            second += 1;
            if (second <= 9)
            {
                t1.Text = "0" + second.ToString();
            }
            else
            {
                t1.Text = second.ToString();
            }
            if (second >= 30)
            {
                timer1.Stop();
                questionscreen.Stop();
                MessageBox.Show("Time Out");
            button1:
                Random r = new Random();
                count = r.Next(0, 22);
                s = search(x, count);

                if (s == true)
                {
                    goto button1;
                }
                else
                {

                    x[check] = count;
                    //MessageBox.Show("ques id " + qid + " count " + count + " int value " + x[check] + "check value " + check);
                    button1.Visible = true;
                    questionscreen.Play();
                    qid++;
                    questioncheck();
                    if (qid == 11)
                    {
                        Form6 f6 = new Form6();
                        this.Hide();
                        f6.Show();
                    }

                }
            }
        }


        
    }
}
