using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using PContato0030482223003.Formularios;

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
            SqlDataAdapter daCidade;
            DataTable dtCidade = new DataTable();
            try
            {
                daCidade = new SqlDataAdapter("SELECT * FROM CIDADE", frmPrincipal.conexao);
                daCidade.Fill(dtCidade);
                daCidade.FillSchema(dtCidade, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtCidade;
        }

        public int Salvar()
        {
            int nReg = 0;
            try
            {
                SqlCommand mycommand;
                mycommand = new SqlCommand("INSERT INTO CIDADE VALUES (@nome_cidade, @uf_cidade)", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@nome_cidade",
               SqlDbType.VarChar)); ;
                mycommand.Parameters.Add(new SqlParameter("@uf_cidade",
               SqlDbType.VarChar));
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
            int nReg = 0;
            try
            {
                SqlCommand mycommand;
                mycommand = new SqlCommand("UPDATE CIDADE SET nome_cidade = @nome_cidade, uf_cidade = @uf_cidade WHERE id_cidade = @id_cidade", frmPrincipal.conexao);
                mycommand.Parameters.Add(new SqlParameter("@id_cidade",
               SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@nome_cidade",
               SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@uf_cidade",
               SqlDbType.Char));
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
            int nReg = 0;
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