namespace MyRepeatDesktop;

public partial class Form1 : Form
{
    public int index = 0;

    public Form1()
    {
        InitializeComponent();

        btnUpdate.Visible = false;
        //btnSave.Visible = true;
        btnCancel.Visible = false;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        lstTodos.Items.Add(txtWork.Text);
        txtWork.Text = "";
    }

    private void lstTodos_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        if (MessageBox.Show("Silmek istiyor musunuz?", "Sil?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
        lstTodos.Height = 244;
        lstTodos.Location = new Point(12, 175);


    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        lstTodos.Items[index] = txtWork.Text;
        txtWork.Text = "";
        btnUpdate.Visible = false;
        btnCancel.Visible = false;
        btnSave.Visible = true;
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        btnCancel.Visible = false;
        btnUpdate.Visible = false;
        btnSave.Visible = true;
        txtWork.Text = "";
        lstTodos.Height = 244;
        lstTodos.Location = new Point(12, 130);
    }
}
