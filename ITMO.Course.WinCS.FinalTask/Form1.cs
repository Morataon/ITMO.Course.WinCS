using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public class Calc : Form
    {
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btnChangesign;
        private System.Windows.Forms.Button btnpoint;
        private System.Windows.Forms.Button btn_result;
        private System.Windows.Forms.Button btn_division;
        private System.Windows.Forms.Button btn_multiplication;
        private System.Windows.Forms.Button btn_addition;
        private System.Windows.Forms.Button btn_subtraction;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.ComponentModel.Container components = null;
        /// <summary>
        /// Объявляем и инициализируем переменные, которые будут
        ///  возникать на экране при нажатии соответствующих кнопок.
        /// </summary>
        private const string one = "1";
        private const string two = "2";
        private const string three = "3";
        private const string four = "4";
        private const string five = "5";
        private const string six = "6";
        private const string seven = "7";
        private const string eight = "8";
        private const string nine = "9";
        private System.Windows.Forms.Button btn_;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem restartToolStripMenuItem;
        private ToolStripMenuItem restartToolStripMenuItem1;
        private ToolStripMenuItem minimizeToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem calcTypeToolStripMenuItem;
        private ToolStripMenuItem defaultToolStripMenuItem;
        private ToolStripMenuItem engineerToolStripMenuItem;
        private const string zero = "0";

        public Calc()
        {
            TopMost = true;
            InitializeComponent();
            Cursor = Cursors.Hand;
            // При запуске приложения на экране будет ноль
            txtOutput.Text = "0";

        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        private void txtOutput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Введите число");
            }

        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calc));
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btnChangesign = new System.Windows.Forms.Button();
            this.btnpoint = new System.Windows.Forms.Button();
            this.btn_result = new System.Windows.Forms.Button();
            this.btn_division = new System.Windows.Forms.Button();
            this.btn_multiplication = new System.Windows.Forms.Button();
            this.btn_addition = new System.Windows.Forms.Button();
            this.btn_subtraction = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn_ = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.engineerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.AccessibleName = "Display";
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtOutput.Location = new System.Drawing.Point(10, 32);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(250, 26);
            this.txtOutput.TabIndex = 60;
            this.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOutput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOutput_KeyPress);
            // 
            // btn_clear
            // 
            this.btn_clear.AccessibleName = "reset";
            this.btn_clear.Location = new System.Drawing.Point(202, 120);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(40, 80);
            this.btn_clear.TabIndex = 0;
            this.btn_clear.Text = "C";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btnChangesign
            // 
            this.btnChangesign.AccessibleName = "change sign";
            this.btnChangesign.Location = new System.Drawing.Point(66, 240);
            this.btnChangesign.Name = "btnChangesign";
            this.btnChangesign.Size = new System.Drawing.Size(40, 40);
            this.btnChangesign.TabIndex = 58;
            this.btnChangesign.Text = "+/-";
            this.btnChangesign.Click += new System.EventHandler(this.btnChangesign_Click);
            // 
            // btnpoint
            // 
            this.btnpoint.AccessibleName = "point ";
            this.btnpoint.Location = new System.Drawing.Point(106, 240);
            this.btnpoint.Name = "btnpoint";
            this.btnpoint.Size = new System.Drawing.Size(40, 40);
            this.btnpoint.TabIndex = 57;
            this.btnpoint.Text = ",";
            this.btnpoint.Click += new System.EventHandler(this.btnpoint_Click);
            // 
            // btn_result
            // 
            this.btn_result.AccessibleDescription = "ravno";
            this.btn_result.AccessibleName = "equal";
            this.btn_result.Location = new System.Drawing.Point(202, 200);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(40, 80);
            this.btn_result.TabIndex = 56;
            this.btn_result.Text = "=";
            this.btn_result.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // btn_division
            // 
            this.btn_division.AccessibleName = "divide ";
            this.btn_division.Location = new System.Drawing.Point(162, 120);
            this.btn_division.Name = "btn_division";
            this.btn_division.Size = new System.Drawing.Size(40, 40);
            this.btn_division.TabIndex = 55;
            this.btn_division.Text = "/";
            this.btn_division.Click += new System.EventHandler(this.btn_division_Click);
            // 
            // btn_multiplication
            // 
            this.btn_multiplication.AccessibleName = "multiply ";
            this.btn_multiplication.Location = new System.Drawing.Point(162, 160);
            this.btn_multiplication.Name = "btn_multiplication";
            this.btn_multiplication.Size = new System.Drawing.Size(40, 40);
            this.btn_multiplication.TabIndex = 54;
            this.btn_multiplication.Text = "*";
            this.btn_multiplication.Click += new System.EventHandler(this.btn_multiplication_Click);
            // 
            // btn_addition
            // 
            this.btn_addition.AccessibleName = "plus ";
            this.btn_addition.Location = new System.Drawing.Point(162, 240);
            this.btn_addition.Name = "btn_addition";
            this.btn_addition.Size = new System.Drawing.Size(40, 40);
            this.btn_addition.TabIndex = 53;
            this.btn_addition.Text = "+";
            this.btn_addition.Click += new System.EventHandler(this.btn_addition_Click);
            // 
            // btn_subtraction
            // 
            this.btn_subtraction.AccessibleName = "minus ";
            this.btn_subtraction.Location = new System.Drawing.Point(162, 200);
            this.btn_subtraction.Name = "btn_subtraction";
            this.btn_subtraction.Size = new System.Drawing.Size(40, 40);
            this.btn_subtraction.TabIndex = 52;
            this.btn_subtraction.Text = "-";
            this.btn_subtraction.Click += new System.EventHandler(this.btn_subtraction_Click);
            // 
            // btn0
            // 
            this.btn0.AccessibleName = "zero";
            this.btn0.Location = new System.Drawing.Point(26, 240);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(40, 40);
            this.btn0.TabIndex = 51;
            this.btn0.Text = "0";
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn9
            // 
            this.btn9.AccessibleName = "nine ";
            this.btn9.Location = new System.Drawing.Point(106, 120);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(40, 40);
            this.btn9.TabIndex = 50;
            this.btn9.Text = "9";
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.AccessibleName = "eight ";
            this.btn8.Location = new System.Drawing.Point(66, 120);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(40, 40);
            this.btn8.TabIndex = 49;
            this.btn8.Text = "8";
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.AccessibleName = "seven ";
            this.btn7.Location = new System.Drawing.Point(26, 120);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(40, 40);
            this.btn7.TabIndex = 48;
            this.btn7.Text = "7";
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.AccessibleName = "six ";
            this.btn6.Location = new System.Drawing.Point(106, 160);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(40, 40);
            this.btn6.TabIndex = 47;
            this.btn6.Text = "6";
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.AccessibleName = "five ";
            this.btn5.Location = new System.Drawing.Point(66, 160);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(40, 40);
            this.btn5.TabIndex = 46;
            this.btn5.Text = "5";
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.AccessibleName = "four ";
            this.btn4.Location = new System.Drawing.Point(26, 160);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(40, 40);
            this.btn4.TabIndex = 45;
            this.btn4.Text = "4";
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.AccessibleName = "three ";
            this.btn3.Location = new System.Drawing.Point(106, 200);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(40, 40);
            this.btn3.TabIndex = 44;
            this.btn3.Text = "3";
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.AccessibleName = "two ";
            this.btn2.Location = new System.Drawing.Point(66, 200);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(40, 40);
            this.btn2.TabIndex = 43;
            this.btn2.Text = "2";
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.AccessibleName = "one ";
            this.btn1.Location = new System.Drawing.Point(26, 200);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(40, 40);
            this.btn1.TabIndex = 42;
            this.btn1.Text = "1";
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn_
            // 
            this.btn_.AccessibleName = "divide ";
            this.btn_.Location = new System.Drawing.Point(27, 66);
            this.btn_.Name = "btn_";
            this.btn_.Size = new System.Drawing.Size(40, 40);
            this.btn_.TabIndex = 61;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.calcTypeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(270, 24);
            this.menuStrip1.TabIndex = 62;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem1,
            this.minimizeToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.restartToolStripMenuItem.Text = "Menu";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem1
            // 
            this.restartToolStripMenuItem1.Name = "restartToolStripMenuItem1";
            this.restartToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.restartToolStripMenuItem1.Text = "Restart";
            this.restartToolStripMenuItem1.Click += new System.EventHandler(this.restartToolStripMenuItem1_Click);
            // 
            // minimizeToolStripMenuItem
            // 
            this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.minimizeToolStripMenuItem.Text = "Minimize";
            this.minimizeToolStripMenuItem.Click += new System.EventHandler(this.minimizeToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // calcTypeToolStripMenuItem
            // 
            this.calcTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem,
            this.engineerToolStripMenuItem});
            this.calcTypeToolStripMenuItem.Name = "calcTypeToolStripMenuItem";
            this.calcTypeToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.calcTypeToolStripMenuItem.Text = "CalcType";
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.defaultToolStripMenuItem.Text = "Default";
            // 
            // engineerToolStripMenuItem
            // 
            this.engineerToolStripMenuItem.Name = "engineerToolStripMenuItem";
            this.engineerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.engineerToolStripMenuItem.Text = "Engineer";
            // 
            // Calc
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(270, 300);
            this.Controls.Add(this.btn_);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btnChangesign);
            this.Controls.Add(this.btnpoint);
            this.Controls.Add(this.btn_result);
            this.Controls.Add(this.btn_division);
            this.Controls.Add(this.btn_multiplication);
            this.Controls.Add(this.btn_addition);
            this.Controls.Add(this.btn_subtraction);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Calc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calc Morgunov";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new Calc());
        }
        /// <summary>
        /// Обработчики для кнопок  обращаются к методу onScreen класса calcMech
        /// и передают ему одну из постоянных (one, two, three  и т.д.). Результат, возвращаемый методом,
        /// присваивается  свойству Text текстового поля txtOutput.
        /// </summary>

        private void btn1_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = calcMech.onScreen(one);
        }

        private void btn2_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = calcMech.onScreen(two);
        }

        private void btn3_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = calcMech.onScreen(three);
        }

        private void btn4_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = calcMech.onScreen(four);
        }

        private void btn5_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = calcMech.onScreen(five);
        }

        private void btn6_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = calcMech.onScreen(six);
        }

        private void btn7_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = calcMech.onScreen(seven);
        }

        private void btn8_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = calcMech.onScreen(eight);
        }

        private void btn9_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = calcMech.onScreen(nine);
        }

        private void btn0_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = calcMech.onScreen(zero);
        }

        private void btnChangesign_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = calcMech.MarkNumber();
        }

        private void btnpoint_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = calcMech.MarkPoint();
        }
        /// <summary>
        /// Обработчики кнопок действия калькулятора передают 
        /// методу DoCalc класса calcMech переменную перечисления Do.
        /// </summary>

        private void btn_division_Click(object sender, System.EventArgs e)
        {
            calcMech.DoCalc(calcMech.Do.Division);
        }

        private void btn_multiplication_Click(object sender, System.EventArgs e)
        {
            calcMech.DoCalc(calcMech.Do.Multiplication);
        }

        private void btn_subtraction_Click(object sender, System.EventArgs e)
        {
            calcMech.DoCalc(calcMech.Do.Subtraction);
        }

        private void btn_addition_Click(object sender, System.EventArgs e)
        {
            calcMech.DoCalc(calcMech.Do.Addition);
        }

        private void btn_result_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = calcMech.EqualMark();
            calcMech.Clear();
        }

        private void btn_clear_Click(object sender, System.EventArgs e)
        {
            calcMech.Clear();
            txtOutput.Text = "0";
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void restartToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            calcMech.Clear();
            txtOutput.Text = "0";
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    class calcMech
    {
        /// <summary>
        ///Создаем перечисление Do, для определения одного из четырех действия калькулятора.
        /// </summary>
        public enum Do : int
        {
            IndefiniteAction = 0,
            Addition = 1,
            Subtraction = 2,
            Multiplication = 3,
            Division = 4
        }

        /// <summary>
        /// Объявляем и инициализируем переменную, 
        /// которая будет использоваться для смены знака при нажатии клавиши (+/-)
        /// </summary>

        private static double negativeVariable = -1;

        /// <summary>
        /// Объвляем переменные, для работы калькулятора:
        /// calculationResult - переменная для хранения 
        ///  промежуточного результата в механизме калькулятора 
        ///  resultOutput - переменная, значение которой будет сниматься с экрана и  выводиться на него. 
        ///  nowDoCalc - хранение одного из действия калькулятора. 
        ///  firstNumber - переменная, в которую будет записываться число на экране 
        ///   до нажатия на одну из четырех кнопок с действием.
        ///  secondNumber - второе число на экране
        ///  addDigit при добавлении следующего  разряда эта переменная примет значение true; 
        ///  dottedNumber при добавлении десятичного разряда (знака точки) эта переменная примет значение true
        /// </summary>

        private static double calculationResult;
        private static string resultOutput;
        private static Do nowDoCalc;
        private static double firstNumber;
        private static double secondNumber;
        private static bool addDigit;
        private static bool dottedNumber;

        /// <summary>
        /// В конструкторе класса calcMech инициализируем переменные 
        /// dottedNumber и addinDigit - при запуске калькулятора на экране 
        /// нет ни разрядности, ни десятичной части.
        /// </summary>

        public calcMech()
        {
            dottedNumber = false;
            addDigit = false;
        }


        /// <summary>
        /// В этом методе переменная resultOutput изменяется - при вводе числа ее значение перезаписывается.
        /// </summary>


        public static string onScreen(string pressedButton)
        {
            resultOutput = resultOutput + pressedButton;
            return (resultOutput);
        }
        /// <summary>
        /// Метод, в котором определяется mathOperation - одно значение перечисления Do,
        ///в зависимости от выбора  клавиши +, -, *,  или /
        /// </summary>

        public static void DoCalc(Do mathOperation)
        {
            try
            {
                if (resultOutput != "" && !addDigit)
                {
                    firstNumber = System.Convert.ToDouble(resultOutput);
                    nowDoCalc = mathOperation;
                    resultOutput = "";
                    dottedNumber = false;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }


        /// <summary>
        /// При нажатии  кнопки +/- число на экране - currentNumber умножается на -1,
        ///  а затем результат снова присваивается переменной resultOutput.
        /// </summary>


        public static string MarkNumber()
        {
            double currentNumber;

            if (resultOutput != "")
            {
                currentNumber = System.Convert.ToDouble(resultOutput);
                resultOutput = System.Convert.ToString(currentNumber * negativeVariable);
            }

            return (resultOutput);
        }

        /// <summary>
        /// При нажатии кнопки ( , ) переменная resultOutput приобретает дробную часть.
        /// </summary>


        public static string MarkPoint()
        {
            if (!dottedNumber && !addDigit)
            {
                if (resultOutput != "")
                    resultOutput = resultOutput + ",";
                else
                    resultOutput = "0,";

                dottedNumber = true;
            }

            return (resultOutput);
        }

        /// <summary>
        /// При нажатии кнопки = (EqualMark) обрабатываются значения 
        /// переменнных firstNumber и secondNumber, результат присваивается переменной calculationResult 
        /// которая  затем преобразуется в resultOutput.
        /// </summary>


        public static string EqualMark()
        {
            bool checkErrors = false;

            if (resultOutput != "")
            {
                secondNumber = System.Convert.ToDouble(resultOutput);
                addDigit = true;

                switch (nowDoCalc)
                {
                    case Do.IndefiniteAction:
                        checkErrors = false;
                        break;

                    case Do.Addition:
                        calculationResult = firstNumber + secondNumber;
                        checkErrors = true;
                        break;

                    case Do.Subtraction:
                        calculationResult = firstNumber - secondNumber;
                        checkErrors = true;
                        break;

                    case Do.Multiplication:
                        calculationResult = firstNumber * secondNumber;
                        checkErrors = true;
                        break;

                    case Do.Division:
                        calculationResult = firstNumber / secondNumber;
                        checkErrors = true;
                        break;

                    default:
                        checkErrors = false;
                        break;
                }

                if (checkErrors)
                    resultOutput = System.Convert.ToString(calculationResult);
            }

            return (resultOutput);
        }

        /// <summary>
        /// При нажатии кнопки С (сброс) значения переменных обнуляются.
        /// </summary>

        public static void Clear()
        {
            calculationResult = 0;
            firstNumber = 0;
            secondNumber = 0;
            resultOutput = "";
            nowDoCalc = Do.IndefiniteAction;
            dottedNumber = false;
            addDigit = false;
        }
    }
}
