using System.Windows.Forms;
//Importação da camada de negócio
using Projeto3Camadas.CODE.BLL;
using Projeto3Camadas.CODE.DTO; //nomeProjeto.nomeDaPasta.nomeDaPasta
namespace Projeto3Camadas.UI
{
    public partial class Form1 : Form
    {  //Criação dos objetos que acessam a camada de negócio
        facebookbll medbll = new facebookbll();
        facebookdto meddto = new facebookdto();
        public Form1()
        {
            InitializeComponent();
        }

        private void btncadastrar_Click(object sender, System.EventArgs e)
        {
            //Preenchimento do objeto
            meddto.Legenda = txtlegenda.Text;
            meddto.Local_postagem = txtlocal.Text;


            if (txtlegenda.Text != "" || txtlocal.Text != "")
            {
                //Envio do dto preenchido para o método inserir
                medbll.Inserir(meddto);

                //Mensagem de sucesso
                MessageBox.Show("Cadastrado com sucesso!", "Lojas Rede", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Limpeza dos componentes
                txtid.Clear();
                txtlegenda.Clear();
                txtlocal.Clear();

            }
            else
            {
                //Mensagem de erro
                MessageBox.Show("Erro, preencha todos os campos!", "Lojas Rede", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Quando o usuario clicar em um registro da lista, os dados serão preenchidos
            txtid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtlegenda.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtlocal.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            dataGridView1.DataSource = medbll.Listar();
        }

        private void btnalterar_Click(object sender, System.EventArgs e)
        {
            //Preenchimento do objeto
            meddto.Id = int.Parse(txtid.Text);
            meddto.Legenda = (txtlegenda.Text);
            meddto.Local_postagem = (txtlocal.Text);

            //Envio do dto preenchido para método editar
            medbll.Editar(meddto);

            //Mensagem de sucesso
            MessageBox.Show("Alterado com sucesso!", "Lojas Rede", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Atualização do GridView
            medbll.Listar();

            //Limpeza dos componentes
            txtid.Clear();
            txtlegenda.Clear();
            txtlocal.Clear();
        }

        private void btnexcluir_Click(object sender, System.EventArgs e)
        {
            //Preenchimento do objeto
            meddto.Id = int.Parse(txtid.Text);

            //Envio do dto preenchido para o método editar
            medbll.Excluir(meddto);

            //Mensagem de sucesso
            MessageBox.Show("Excluido com sucesso!", "Lojas Rede", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Atualização do GridView
            medbll.Listar();

            //Limpeza dos componentes
            txtid.Clear();
            txtlegenda.Clear();
            txtlocal.Clear();
        }
    }
}
