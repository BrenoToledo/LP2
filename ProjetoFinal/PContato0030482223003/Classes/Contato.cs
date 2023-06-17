using PContato0030482223003.Formularios;
using System;
using System.Data.SqlClient;
using System.Data;

namespace PContato0030482223003.Classes
{
    public class Contato
    {
        private int _idContato;
        private string _nomeContato;
        private string _endContato;
        private int _cidadeIdContato;
        private string _celContato;
        private string _emailContato;
        private DateTime _dataCadastroContato;

        public int IdContato { get => _idContato; set => _idContato = value; }
        public string NomeContato { get => _nomeContato; set => _nomeContato = value; }
        public string EndContato { get => _endContato; set => _endContato = value; }
        public int CidadeIdContato { get => _cidadeIdContato; set => _cidadeIdContato = value; }
        public string CelContato { get => _celContato; set => _celContato = value; }
        public string EmailContato { get => _emailContato; set => _emailContato = value; }
        public DateTime DataCadastroContato { get => _dataCadastroContato; set => _dataCadastroContato = value; }

        public DataTable Listar()
        {
            SqlDataAdapter adapterContato;
            DataTable tableContato = new DataTable();
            try
            {
                adapterContato = new SqlDataAdapter("SELECT * FROM CONTATO", frmPrincipal.conexao);
                adapterContato.Fill(tableContato);
                adapterContato.FillSchema(tableContato, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return tableContato;
        }

        public int Salvar()
        {
            int nReg;
            try
            {
                SqlCommand mycommand;
                mycommand = new SqlCommand("INSERT INTO CONTATO VALUES (@nome_contato, @end_contato, @cidade_id_cidade, @cel_contato, @email_contato, @dtcadastro_contato)", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@nome_contato", SqlDbType.VarChar)).Value = NomeContato;
                mycommand.Parameters.Add(new SqlParameter("@end_contato", SqlDbType.VarChar)).Value = EndContato;
                mycommand.Parameters.Add(new SqlParameter("@cidade_id_cidade", SqlDbType.Int)).Value = CidadeIdContato;
                mycommand.Parameters.Add(new SqlParameter("@cel_contato", SqlDbType.VarChar)).Value = CelContato;
                mycommand.Parameters.Add(new SqlParameter("@email_contato", SqlDbType.VarChar)).Value = EmailContato;
                mycommand.Parameters.Add(new SqlParameter("@dtcadastro_contato", SqlDbType.Date)).Value = DataCadastroContato;
                mycommand.Parameters["@nome_contato"].Value = _nomeContato;
                mycommand.Parameters["@end_contato"].Value = _endContato;
                mycommand.Parameters["@cidade_id_cidade"].Value = _cidadeIdContato;
                mycommand.Parameters["@cel_contato"].Value = _celContato;
                mycommand.Parameters["@email_contato"].Value = _emailContato;
                mycommand.Parameters["@dtcadastro_contato"].Value = _dataCadastroContato;
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
                mycommand = new SqlCommand("UPDATE CONTATO SET nome_contato = @nome_contato, end_contato = @end_contato, cidade_id_cidade = @cidade_id_cidade, cel_contato = @cel_contato, email_contato = @email_contato, dtcadastro_contato = @dtcadastro_contato WHERE id_contato = @id_contato", frmPrincipal.conexao);
                mycommand.Parameters.Add(new SqlParameter("@id_contato", SqlDbType.Int)).Value = IdContato;
                mycommand.Parameters.Add(new SqlParameter("@nome_contato", SqlDbType.VarChar)).Value = NomeContato;
                mycommand.Parameters.Add(new SqlParameter("@end_contato", SqlDbType.VarChar)).Value = EndContato;
                mycommand.Parameters.Add(new SqlParameter("@cidade_id_cidade", SqlDbType.Int)).Value = CidadeIdContato;
                mycommand.Parameters.Add(new SqlParameter("@cel_contato", SqlDbType.VarChar)).Value = CelContato;
                mycommand.Parameters.Add(new SqlParameter("@email_contato", SqlDbType.VarChar)).Value = EmailContato;
                mycommand.Parameters.Add(new SqlParameter("@dtcadastro_contato", SqlDbType.Date)).Value = DataCadastroContato;
                mycommand.Parameters["@id_contato"].Value = _idContato;
                mycommand.Parameters["@nome_contato"].Value = _nomeContato;
                mycommand.Parameters["@end_contato"].Value = _endContato;
                mycommand.Parameters["@cidade_id_cidade"].Value = _cidadeIdContato;
                mycommand.Parameters["@cel_contato"].Value = _celContato;
                mycommand.Parameters["@email_contato"].Value = _emailContato;
                mycommand.Parameters["@dtcadastro_contato"].Value = _dataCadastroContato;
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
                mycommand = new SqlCommand("DELETE FROM CONTATO WHERE id_contato = @id_contato", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@id_contato", SqlDbType.Int));
                mycommand.Parameters["@id_contato"].Value = Convert.ToInt16(_idContato);

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