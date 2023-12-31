namespace Projeto_SistemaLojaRoupas
{
    internal class Program
    {
        static string[,] matProduto = new string[100, 4];
        static string[,] matVenda = new string[100, 3];
        static int ultimaPosicaoProduto = 0;
        static int ultimaPosicaoVenda = 0;


        static void Main(string[] args)
        {
            bool controleMenu = true;
            int opcao;


            do
            {
                VerificarEstoque();
                Console.WriteLine(" ");
                Console.WriteLine("Selecione uma das opções abaixo: ");
                Menu();
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();


                switch (opcao)
                {
                    case 0:
                        controleMenu = false;
                        break;
                    case 1:
                        cadastrarProdutos();
                        break;
                    case 2:
                        realizarVendas();
                        break;
                    case 3:
                        relatorioVendas();
                        break;
                    case 4:
                        relatorioFuncionario();
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.Clear();
            } while (controleMenu == true);


        }


        static void Menu()
        {
            Console.WriteLine("Menu: ");
            Console.WriteLine("========================================");
            Console.WriteLine("1 - Cadastrar produtos");
            Console.WriteLine("2 - Realizar uma venda");
            Console.WriteLine("3 - Relatório de vendas");
            Console.WriteLine("4 - Relatório de vendas por funcionários");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("========================================");
        }


        static void VerificarEstoque()
        {


            for (int l = 0; l < 100; l++)
            {
                if (!String.IsNullOrEmpty(matProduto[l, 0]))
                {
                    Console.WriteLine($"{matProduto[l, 0]} || {matProduto[l, 1]} || {matProduto[l, 2]} || {matProduto[l, 3]} ||");
                }
            }
        }


        static void cadastrarProdutos()
        {          
            VerificarEstoque();
            Console.WriteLine("\n");


            Console.WriteLine("Iniciar cadastro: _");


            Console.WriteLine("Informe o código produto para cadastrar:_");
            matProduto[ultimaPosicaoProduto, 0] = Console.ReadLine();


            Console.WriteLine("Informe a descrição do produto para cadastrar:_");
            matProduto[ultimaPosicaoProduto, 1] = Console.ReadLine();


            Console.WriteLine("Informe o valor do produto:_");
            matProduto[ultimaPosicaoProduto, 2] = Console.ReadLine();


            Console.WriteLine("Informe a quantidade em estoque:_");
            matProduto[ultimaPosicaoProduto, 3] = Console.ReadLine();


            ultimaPosicaoProduto += 1;
        }


        static void realizarVendas()
        {
           
            VerificarEstoque();
            Console.WriteLine("\n");


            int quantidadeEmEstoque, quantidadeVendida;
            string codigoProduto, funcionarioVenda;


            Console.WriteLine("Iniciar uma venda:_");


            Console.WriteLine("Informe o código do produto para prosseguir com a venda:_");
            codigoProduto = Console.ReadLine();


            Console.WriteLine("Informe o código do funcionário para prosseguir com a venda:_");
            funcionarioVenda = Console.ReadLine();


            Console.WriteLine("Informe a quantidade a se vender do produto:_");
            quantidadeVendida = Convert.ToInt32(Console.ReadLine());


            quantidadeEmEstoque = RetornarQuantidadeEstoqueProduto(codigoProduto);


            if (quantidadeEmEstoque >= quantidadeVendida)
            {
                matVenda[ultimaPosicaoVenda, 0] = codigoProduto;
                matVenda[ultimaPosicaoVenda, 1] = funcionarioVenda;
                matVenda[ultimaPosicaoVenda, 2] = Convert.ToString(quantidadeVendida);


                AtualizarQuantidadeEstoqueProduto(codigoProduto, (quantidadeEmEstoque - quantidadeVendida));


                ultimaPosicaoVenda += 1;
            }
            else
            {
                Console.WriteLine("Produto não tem quantidade de estoque disponível para realizar a venda.");
                Console.WriteLine();
            }


            Console.ReadKey();
        }


        static void relatorioVendas()
        {          


            VerificarEstoque();
            Console.WriteLine("\n");
            Console.WriteLine("Código|| Funcionário || Valor\r\n============================\r\n");


            double Totaldevendas = 0;


            for (int l = 0; l < 100; l++)
            {
                string valorProduto = " ";
                for (int l2 = 0; l2 < 100; l2++)
                {
                    if (!string.IsNullOrEmpty(matVenda[l2, 0]))
                    {
                        if (matProduto[l2, 0] == (matVenda[l2, 0]))
                        {
                            valorProduto = (Convert.ToDouble(matProduto[l2, 2]) * (Convert.ToDouble(matVenda[l, 2]))).ToString();


                            Totaldevendas = Convert.ToDouble(valorProduto) + Totaldevendas;
                            break;
                        }


                    }


                }
                if (!string.IsNullOrEmpty(matVenda[l, 0]))
                {
                    Console.WriteLine($"{matVenda[l, 0]} || {matVenda[l, 1]} || {valorProduto}");
                }


            }


            Console.WriteLine("\n");
            Console.WriteLine("=================================");
            Console.WriteLine("O valor total das vendas foi: R$ " + Totaldevendas);
        }


        static void relatorioFuncionario()
        {
           
            string valorProduto = " ";


            VerificarEstoque();
            Console.WriteLine("\n");


            Console.WriteLine("Digite o código do funcionário para obter o relátorio: ");    
            string codFuncionario = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Código|| Funcionário || Valor\r\n============================\r\n");


            double TotaldevendasFunc = 0;


            for (int l = 0; l < 100; l++)
            {
                for (int l2 = 0; l2 < 100; l2++)
                {
                    if (!string.IsNullOrEmpty(matProduto[l2, 0]) && (matVenda[l, 1] == codFuncionario))
                    {


                        if (matProduto[l2, 0] == (matVenda[l, 0]))
                        {
                            valorProduto = (Convert.ToDouble(matProduto[l2, 2]) * (Convert.ToDouble(matVenda[l, 2]))).ToString();


                            TotaldevendasFunc = Convert.ToDouble(valorProduto) + TotaldevendasFunc;
                            break;
                        }


                    }
                }
                if (!string.IsNullOrEmpty(matProduto[l, 0]) && (matVenda[l, 1] == codFuncionario))
                {
                    Console.WriteLine($"  {matVenda[l, 0]} ||   {matVenda[l, 1]}   ||   {valorProduto}");
                }


            }


            double comissionamento = (Convert.ToDouble(TotaldevendasFunc) * 0.10);            
            Console.WriteLine("============================");
            Console.WriteLine("\n");
            Console.WriteLine("O total das vendas do funcionário " + codFuncionario + " foi de R$" + TotaldevendasFunc + " e o comissionamento foi de : R$ " + comissionamento);

        }




        static int RetornarQuantidadeEstoqueProduto(string codigoProduto)
        {
            int quantidadeEmEstoque = 0;


            for (int l = 0; l < 100; l++)
            {
                if (matProduto[l, 0] == codigoProduto)
                {
                    quantidadeEmEstoque = Convert.ToInt32(matProduto[l, 3]);
                    break;
                }


            }


            return quantidadeEmEstoque;
        }


        static void AtualizarQuantidadeEstoqueProduto(string codigoProduto, int quantidadeEstoque)
        {


            for (int l = 0; l < 100; l++)
            {
                if (matProduto[l, 0] == codigoProduto)
                {
                    matProduto[l, 3] = Convert.ToString(quantidadeEstoque);
                }
            }
        }


    }
}
