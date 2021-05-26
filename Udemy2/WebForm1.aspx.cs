using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Udemy2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // não vai deixar executar esse código toda hora
            if (!IsPostBack)
            {
                ListaCursos.Items.Add(new ListItem("Java", "4"));
                ListBox1.Items.Add(new ListItem("Cat", "2"));
                ListBox1.Items.Add(new ListItem("Fish", "3"));
                ListBox1.Items.Add(new ListItem() {Value = "4" ,Text = "shark"});

                povoarFamilia();
            }


            
        }

        private void povoarFamilia()
        {
            List<ListItem> listaFamiliares = new List<ListItem>();
            listaFamiliares.Add(new ListItem() { Value = "1", Text = "Pai Luciano" });
            listaFamiliares.Add(new ListItem() { Value = "2", Text = "Mae Marcela" });
            listaFamiliares.Add(new ListItem() { Value = "3", Text = "Filho Matheus" });
            listaFamiliares.Add(new ListItem() { Value = "4", Text = "Filha Livia" });

            foreach (var f in listaFamiliares)
            {
                familia.Items.Add(new ListItem() { Value = f.Value, Text = f.Text });
            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //adicionando o valor em outra propriedade
            LabelCursos.Text = ListaCursos.SelectedValue;
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LabelCursos.Text = ListBox1.SelectedValue;
        }
        protected void txCursoSelecionado_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            tbSelecionados.Text = "";
            foreach (ListItem listaAnimal in ListBox1.Items){
                if (listaAnimal.Selected)
                {
                    tbSelecionados.Text += listaAnimal.Text + " ";
                }
            }
        }

        
    }
}