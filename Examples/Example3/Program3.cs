using System.Windows.Forms;

class SimpleWindowsForm : Form
{
    // Метод-конструктор нашего класса
    public SimpleWindowsForm()
    {
        // Указываем заголовок окна
        this.Text = "Это простая форма с заголовком";
    }

    static void Main()
    {
        // Создаем новый экземпляр класса
        //и запускаем его на выполнение
        // В результате на экране дисплея откроется форма
        Application.Run(new SimpleWindowsForm());
    }

    private void InitializeComponent()
    {
            this.SuspendLayout();
            // 
            // SimpleWindowsForm
            // 
            this.ClientSize = new System.Drawing.Size(886, 261);
            this.Name = "SimpleWindowsForm";
            this.ResumeLayout(false);

    }
}
