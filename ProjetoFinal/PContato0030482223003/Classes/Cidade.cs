using PContato0030482223003.Formularios;
using System;
using System.Data;
using System.Data.SqlClient;

//Data Source=Apolo;Initial Catalog=LP2;User ID=BD2223003

namespace PContato0030482223003
{
    class Cidade
    {
        private int idcidade;
        private string nomecidade;
        private string ufcidade;

        public int Idcidade { get => idcidade; set => idcidade = value; }
        public string Nomecidade { get => nomecidade; set => nomecidade = value; }
        public string Ufcidade
        {
            get => ufcidade; set => ufcidade = value;
        }

        public DataTable Listar()
        {
            SqlDataAdapter adapterCidade;
            DataTable tableCidade = new DataTable();
            try
            {
                adapterCidade = new SqlDataAdapter("SELECT * FROM CIDADE", frmPrincipal.conexao);
                adapterCidade.Fill(tableCidade);
                adapterCidade.FillSchema(tableCidade, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return tableCidade;
        }

        public int Salvar()
        {
            int nReg;
            try
            {
                SqlCommand mycommand;
                mycommand = new SqlCommand("INSERT INTO CIDADE VALUES (@nome_cidade, @uf_cidade)", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@nome_cidade", SqlDbType.VarChar)); ;
                mycommand.Parameters.Add(new SqlParameter("@uf_cidade", SqlDbType.VarChar));
                mycommand.Parameters["@nome_cidade"].Value = nomecidade;
                mycommand.Parameters["@uf_cidade"].Value = ufcidade;
                nReg = mycommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return nReg;
        }

        public int Alterar()
        {
            int nReg;
            try
            {
                SqlCommand mycommand;
                mycommand = new SqlCommand("UPDATE CIDADE SET nome_cidade = @nome_cidade, uf_cidade = @uf_cidade WHERE id_cidade = @id_cidade", frmPrincipal.conexao);
                mycommand.Parameters.Add(new SqlParameter("@id_cidade", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@nome_cidade", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@uf_cidade", SqlDbType.Char));
                mycommand.Parameters["@id_cidade"].Value = idcidade;
                mycommand.Parameters["@nome_cidade"].Value = nomecidade;
                mycommand.Parameters["@uf_cidade"].Value = ufcidade;
                nReg = mycommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return nReg;
        }

        public int Excluir()
        {
            int nReg;
            try
            {
                SqlCommand mycommand;
                mycommand = new SqlCommand("DELETE FROM CIDADE WHERE id_cidade = @id_cidade", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@id_cidade", SqlDbType.Int));
                mycommand.Parameters["@id_cidade"].Value = Convert.ToInt16(idcidade);
                nReg = mycommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return nReg;
        }
    }

}
