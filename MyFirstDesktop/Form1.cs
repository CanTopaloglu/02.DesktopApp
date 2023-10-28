using System.Text;

namespace MyFirstDesktop;

public partial class Form1 : Form
{
    public int index = 0;
    public Form1()
    {
        InitializeComponent();

        btnUpdate.Visible = false;
        btnCancel.Visible = false;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        lstTodos.Items.Add(txtWork.Text);
        txtWork.Text = "";

        // CRUD iþlemleri CREATE - READ - UPDATE - DELETE 
    }

    private void lstTodos_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        if (MessageBox.Show("Silmek istiyor musunuz?", "Sil?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        {
            lstTodos.Items.Remove(lstTodos.SelectedItem);
            txtWork.Text = "";
        }
    }

    private void lstTodos_MouseClick(object sender, MouseEventArgs e)
    {
        txtWork.Text = lstTodos.SelectedItem.ToString();
        index = lstTodos.SelectedIndex;
        btnUpdate.Visible = true;
        btnCancel.Visible = true;
        btnSave.Visible = false;
        lstTodos.Height = 274;
        lstTodos.Location = new Point(29, 204);
    }

    private void button2_Click(object sender, EventArgs e)
    {
        lstTodos.Items[index] = txtWork.Text; //Listeler köþeli parantez ile eriþilebilir oluyor.
        txtWork.Text = "";
        btnUpdate.Visible = false;
        btnSave.Visible = true;
        btnCancel.Visible = false;
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        btnCancel.Visible = false;
        btnUpdate.Visible = false;
        btnSave.Visible = true;
        txtWork.Text = "";
        lstTodos.Height = 274;
        lstTodos.Location = new Point(29, 204);
    }
}
