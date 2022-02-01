using System.Windows.Forms;
namespace mio;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Ingreso estudiantes";

        this.btn1=new Button();
        this.btn1.Name="btnGuardar";
        this.btn1.Text="Guardar";
        this.btn1.Location=new System.Drawing.Point(100,250);
        this.btn1.Size=new System.Drawing.Size(100,40);
        this.Controls.Add(btn1);

        this.btn2=new Button();
        this.btn2.Name="btnFor";
        this.btn2.Text="For";
        this.btn2.Location=new System.Drawing.Point(200,250);
        this.btn2.Size=new System.Drawing.Size(110,40);
        this.Controls.Add(btn2);

        this.btn3=new Button();
        this.btn3.Name="btnWhile";
        this.btn3.Text="While";
        this.btn3.Location=new System.Drawing.Point(310,250);
        this.btn3.Size=new System.Drawing.Size(100,40);
        this.Controls.Add(btn3);

        this.btn4=new Button();
        this.btn4.Name="btndoWhile";
        this.btn4.Text="doWhile";
        this.btn4.Location=new System.Drawing.Point(480,300);
        this.btn4.Size=new System.Drawing.Size(130,40);
        this.Controls.Add(btn4);

        this.btn5=new Button();
        this.btn5.Name="btnSwitch";
        this.btn5.Text="Switch";
        this.btn5.Location=new System.Drawing.Point(480,350);
        this.btn5.Size=new System.Drawing.Size(110,40);
        this.Controls.Add(btn5);

        this.txt1=new TextBox();
        this.txt1.Name="txtValor1";
        this.txt1.Text=" ";
        this.txt1.Location=new System.Drawing.Point(210,60);
        this.txt1.Size=new System.Drawing.Size(200,40);
        this.Controls.Add(txt1);

        this.txt2=new TextBox();
        this.txt2.Name="txtValor2";
        this.txt2.Text=" ";
        this.txt2.Location=new System.Drawing.Point(210,100);
        this.txt2.Size=new System.Drawing.Size(200,40);
        this.Controls.Add(txt2);

        this.txt3=new TextBox();
        this.txt3.Name="txtValor3";
        this.txt3.Text=" ";
        this.txt3.Location=new System.Drawing.Point(210,140);
        this.txt3.Size=new System.Drawing.Size(200,40);
        this.Controls.Add(txt3);
        
        this.txt4=new TextBox();
        this.txt4.Name="txtValor4";
        this.txt4.Text=" ";
        this.txt4.Location=new System.Drawing.Point(210,180);
        this.txt4.Size=new System.Drawing.Size(200,40);
        this.Controls.Add(txt4);
        
        //presentar información
        this.lbtxt1=new Label();
        this.lbtxt1.Name ="lbTexto1";
        this.lbtxt1.Text="Ingrese el nombre:";
        this.lbtxt1.Location =new System.Drawing.Point (20,60);
        this.lbtxt1.Size=new System.Drawing.Size (180,40);
        this.Controls.Add (lbtxt1);

        this.lbtxt2=new Label();
        this.lbtxt2.Name ="lbTexto2";
        this.lbtxt2.Text="Ingrese el apellido:";
        this.lbtxt2.Location =new System.Drawing.Point (20,100);
        this.lbtxt2.Size=new System.Drawing.Size (180,40);
        this.Controls.Add (lbtxt2);

        this.lbtxt3=new Label();
        this.lbtxt3.Name ="lbTexto3";
        this.lbtxt3.Text="Ingrese el correo:";
        this.lbtxt3.Location =new System.Drawing.Point (20,140);
        this.lbtxt3.Size=new System.Drawing.Size (180,40);
        this.Controls.Add (lbtxt3);

        this.lbtxt4=new Label();
        this.lbtxt4.Name ="lbTexto4";
        this.lbtxt4.Text="Ingrese el edad:";
        this.lbtxt4.Location =new System.Drawing.Point (20,180);
        this.lbtxt4.Size=new System.Drawing.Size (180,40);
        this.Controls.Add (lbtxt4);

        this.lbtxt5=new Label();
        this.lbtxt5.Name ="lbTexto5";
        this.lbtxt5.Text="El promedio es:";
        this.lbtxt5.Location =new System.Drawing.Point (430,20);
        this.lbtxt5.Size=new System.Drawing.Size (150,40);
        this.Controls.Add (lbtxt5);

        this.lbtxt6=new Label();
        this.lbtxt6.Name ="lbTexto6";
        this.lbtxt6.Text="...";
        this.lbtxt6.Location =new System.Drawing.Point (580,20);
        this.lbtxt6.Size=new System.Drawing.Size (50,40);
        this.Controls.Add (lbtxt6);

        this.lbtxt7=new Label();
        this.lbtxt7.Name ="lbTexto7";
        this.lbtxt7.Text="...";
        this.lbtxt7.Location =new System.Drawing.Point (20,300);
        this.lbtxt7.Size=new System.Drawing.Size (230,40);
        this.Controls.Add (lbtxt7);

         this.lbtxt8=new Label();
        this.lbtxt8.Name ="lbTexto8";
        this.lbtxt8.Text="Mayor de edad";
        this.lbtxt8.Location =new System.Drawing.Point (250,300);
        this.lbtxt8.Size=new System.Drawing.Size (230,40);
        this.Controls.Add (lbtxt8);

        //crear listbox
        this.lstB1=new ListBox();
        this.lstB1.Name ="LstEstudiantes";
        this.lstB1.Text="Fila 1";
        this.lstB1.Location =new System.Drawing.Point (430,60);
        this.lstB1.Size=new System.Drawing.Size (300,250);
        this.Controls.Add (lstB1);
        this.lstB1.BeginUpdate();

        //Radiobutton
        this.rbt1=new RadioButton();
        this.rbt1.Name ="RadioButton1";
        this.rbt1.Text="Nombres";
        this.rbt1.Location =new System.Drawing.Point (20,350);
        this.rbt1.Size=new System.Drawing.Size (140,40);
        this.Controls.Add (rbt1);

        this.rbt2=new RadioButton();
        this.rbt2.Name ="RadioButton2";
        this.rbt2.Text="Apellidos";
        this.rbt2.Location =new System.Drawing.Point (180,350);
        this.rbt2.Size=new System.Drawing.Size (140,40);
        this.Controls.Add (rbt2);
    }
    private Button btn1,btn2,btn3,btn4,btn5;
    private TextBox txt1,txt2,txt3,txt4;
    private Label lbtxt1, lbtxt2, lbtxt3, lbtxt4, lbtxt5,lbtxt6, lbtxt7, lbtxt8;
    private ListBox lstB1;
    private RadioButton rbt1,rbt2;

    #endregion
}
