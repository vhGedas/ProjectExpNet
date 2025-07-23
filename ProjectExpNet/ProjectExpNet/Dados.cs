using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExpNet
{
    public class Dados
    {
        public static string Clientes = @"SELECT C.BAIRRO,
                                           C.CEP,
                                           C.NOME_CIDADE,
                                           E.NOME,
                                           C.ESTADOID,
                                           C.CNPJ_CPF,
                                           C.E_MAIL,
                                           C.ENDERECO,
                                           C.RAZAO_SOCIAL,
                                           C.COMPLEMENTO,
                                           C.NUMERO,
                                           C.SITE,
                                           C.INSCRICAO_ESTADUAL,
                                           C.INSCRICAO_MUNICIPAL,
                                           C.NOME_FANTASIA,
                                           C.TIPO_CLIENTE,
                                           C.OPTANTE_SIMPLES,
                                           C.DOC_IDENTIDADE,
                                           C.ORGAO_EXPEDIDOR,
                                           C.UF_ORGAO_EXPEDIDOR,
                                           C.NATURALIDADE,
                                           C.SEXO,
                                           C.ESTADO_CIVIL,
                                           C.NACIONALIDADE,
                                           C.GRUPOID,
                                           G.NOME,
                                           C.TABELA_PRECOID,
                                           C.NOME_TABELA_PRECO,
                                           C.VENDEDORID,
                                           C.CONDICAOID, 
                                           C.NOME_CONDICAO
                                      FROM VW_CLIENTES C, ESTADOS E, GRUPO_CLIENTES G
                                     WHERE  C.ESTADOID = E.ESTADOID
                                       AND C.GRUPOID = G.GRUPOID
                                       AND C.EMPRESAID = G.EMPRESAID
                                       AND C.EMPRESAID = {0}";


        public static string TelefoneCliente = @"SELECT C.CNPJ_CPF, T.DDD, T.NUMERO, T.TELEFONE_DEFAULT AS PRINCIPAL
                                             FROM TELEFONES T, VW_CLIENTES C
                                             WHERE T.EMPRESAID = C.EMPRESAID
                                             AND T.PESSOAID = C.CLIENTEID
                                             AND T.EMPRESAID = {0}";

        public static string Fornecedor = @"SELECT F.BAIRRO,
                                               F.CEP,
                                               F.CIDADE_NOME,
                                               E.NOME,
                                               F.ESTADOID,
                                               F.CNPJ_CPF,
                                               F.E_MAIL,
                                               F.ENDERECO,
                                               F.RAZAO_SOCIAL,
                                               P.COMPLEMENTO,
                                               F.NUMERO,
                                               P.SITE,
                                               F.INSCRICAO_ESTADUAL,
                                               P.INSCRICAO_MUNICIPAL,
                                               F.NOME_FANTASIA,
                                               F.GRUPOID, 
                                               F.NOME_GRUPO,
                                               P.TIPO_IE
                                         FROM VW_FORNECEDORES F, ESTADOS E, PESSOAS P
                                         WHERE P.CLIENTE = 'N'
                                         AND F.ESTADOID = E.ESTADOID
                                         AND F.EMPRESAID = P.EMPRESAID
                                         AND F.FORNECEDORID = P.PESSOAID
                                         AND F.EMPRESAID = {0}";

        public static string TelefoneFornecedor = @"SELECT F.CNPJ_CPF, T.DDD, T.NUMERO, T.TELEFONE_DEFAULT AS PRINCIPAL 
                                                     FROM VW_FORNECEDORES F, TELEFONES T
                                                     WHERE F.EMPRESAID = T.EMPRESAID
                                                     AND F.FORNECEDORID = T.PESSOAID 
                                                     AND T.EMPRESAID = {0}";

        public static string GrupoProd = @"SELECT G.GRUPO_PRODUTOID, G.NOME
                                             FROM GRUPO_PRODUTOS G
                                             WHERE G.EMPRESAID = {0}
                                             ORDER BY G.GRUPO_PRODUTOID";


        public static string Marca = @"SELECT M.MARCAID, M.DESCRICAO
                                         FROM MARCAS M
                                         WHERE M.EMPRESAID = {0}
                                         ORDER BY M.MARCAID";

        public static string Linha = @"SELECT L.LINHAID, L.DESCRICAO
                                         FROM LINHA_PRODUTOS L
                                         WHERE L.EMPRESAID = {0}
                                        ORDER BY L.LINHAID";

        public static string Ncm = @"SELECT N.CODIGO_NCM, N.DESCRICAO, N.DESCRICAO_COMPLEMENTAR
                                     FROM CODIGOS_NCM N";

        public static string Produtos = @"SELECT P.DESC_VENDA,
                                           P.UND_VENDA,
                                           U.DESCRICAO,
                                           P.DESC_GRUPO,
                                           P.DESC_LINHA, 
                                           P.DESC_MARCA,
                                           P.NATUREZA_PRODUTO,
                                           DECODE(P.NATUREZA_PRODUTO,
                                                  'T',
                                                  'TERCEIROS',
                                                  'P',
                                                  'FABRICACAO PROPRIA') AS NATUREZA_PRODUTOS,  
                                            P.CODIGO_NCM, 
                                            P.CODIGO_ORIGEM,
                                            P.CODIGO_GTIN,
                                            VP.PRECO_VENDA, 
                                            P.CODIGO_BARRA,
                                            P.TIPO_CADASTRO,
                                            DECODE(P.TIPO_CADASTRO, 'P', 'PRODUTO', 'S', 'SERVICO') AS TIPO_CADASTRO_NOME,
                                            P.COD_ORIGINAL,
                                            P.CODIGO_PRINCIPAL,
                                            P.CUSTO_COMPRA     
                                     FROM VW_PRODUTOS P, UNIDADES U, VW_PRODUTOS_PRECOS VP
                                     WHERE P.EMPRESAID = U.EMPRESAID
                                     AND P.UND_VENDA = U.UNIDADEID
                                     AND P.EMPRESAID = VP.EMPRESAID
                                     AND P.PRODUTOID = VP.PRODUTOID
                                     AND P.EMPRESAID = {0}";
    }

}
