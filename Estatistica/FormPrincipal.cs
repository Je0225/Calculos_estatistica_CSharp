using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace Estatistica {

    public partial class FormPrincipal: Form {

        private List<int> numerosOrdenados = new List<Int32>();

        public FormPrincipal() {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e) {
            String itemInformado = tbNumero.Text;
            bool converteu = Int32.TryParse(itemInformado, out int outnumeroInformado);
            if (!converteu) {
                tbNumero.Clear(); 
                MessageBox.Show("O número informado não é um valor válido, digite um número inteiro!");
            } else {
                lvNumeros.Items.Add(itemInformado);
                tbNumero.Clear();
            }
            tbNumero.Focus();
        }

        private void btnGerarRol_Click(object sender, EventArgs e) {
            //se lvnumeros.count for igual a 
            ListViewItemCollection itensInformados = lvNumeros.Items;
            if (itensInformados.Count == lvNumerosRol.Items.Count) {
                MessageBox.Show("Os números informados já estão contidos na lista do Rol");
                return;
            }
            // criar uma lista de int (chamar ela de rol)
            List<int> rol = new List<Int32>();

            // varrer os itensInformados e adicionar na lista de inteiros criada (rol)
            foreach (ListViewItem item in itensInformados) {
                bool conversao = Int32.TryParse(item.Text, out int numeroInteiro);
                if (conversao) {
                    rol.Add(numeroInteiro);
                }
                tbNumero.Focus();
            }

            // ordena a lista nova (rol), não o itensInformados
            numerosOrdenados = rol.OrderBy(numeroOrdenado => numeroOrdenado).ToList();
            lvNumerosRol.Items.Clear();
            // adiciona no listView do rol os itens
            foreach (var numero in numerosOrdenados) {
                lvNumerosRol.Items.Add(numero.ToString());
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e) {

            if (numerosOrdenados.Count == 0 && lvNumeros.Items.Count > 0) {
                MessageBox.Show("Clique no botão 'Gerar Rol' antes de calcular os valores");
                return;
            }
            if (lvNumeros.Items.Count == 0) {
                MessageBox.Show("Não há valores para calcular, informe os números e clique em 'Gerar Rol' antes de calcular os valores");
                return;
            }

            Boolean par = numerosOrdenados.Count() % 2 == 0;
            int mediana = 0;
            double soma = 0;
            int minimo = Int32.MaxValue;
            int maximo = Int32.MinValue;

            //Mediana
            if (par) {
                int posicaoMediana = (numerosOrdenados.Count() / 2);
                int posicaoMediana2 = (numerosOrdenados.Count() / 2) + 1;
                mediana = (numerosOrdenados[posicaoMediana - 1] + numerosOrdenados[posicaoMediana2 - 1]) / 2;
            } else {
                int posicaoMediana = (numerosOrdenados.Count() + 1) / 2;
                mediana = numerosOrdenados[posicaoMediana - 1];
            }
            lbMedianaResult.Text = mediana.ToString();

            Dictionary<int, int> ocorrencias = new Dictionary<int, int>();
            foreach (int numero in numerosOrdenados) {
                soma = soma + numero;

                //maximo
                if (numero > maximo) {
                    maximo = numero;
                }
                // minimo
                if (numero < minimo) {
                    minimo = numero;
                }
                //contagem pra moda
                if (ocorrencias.ContainsKey(numero)) {
                    ocorrencias[numero] = ocorrencias[numero] + 1;
                } else {
                    ocorrencias.Add(numero, 1);
                }
            }

            //moda
            String valorModa = "Default";
            KeyValuePair<Int32, Int32> moda = new KeyValuePair<Int32, Int32>();
            bool todosIguais = ocorrencias.Values.All(v => v == ocorrencias.Values.First());

            if (todosIguais) {
                valorModa = "Amodal";
            } else {
                foreach (KeyValuePair<Int32, Int32> ocorrencia in ocorrencias) {
                    if (ocorrencia.Value >= moda.Value) {
                        if (ocorrencia.Value > moda.Value) {
                            moda = ocorrencia;
                            valorModa = moda.Key.ToString();
                        } else if (ocorrencia.Value == moda.Value) {
                            valorModa = valorModa + ", " + ocorrencia.Key;
                        }
                    }
                }
            }

            // foreach (KeyValuePair<Int32, Int32> ocorrencia in ocorrencias) {
            //    if (ocorrencia.Value != moda.Value) {
            //      if (ocorrencia.Value > moda.Value) {
            //        moda = ocorrencia;
            //      valorModa = moda.Key.ToString();
            // }
            // else {
            // moda = moda0;
            // valorModa = "Não há moda";
            // }
            // }

            //media
            double media = soma / numerosOrdenados.Count;

            //variância e desvio padrão
            double diferenca = 0;
            foreach (var num in numerosOrdenados) {
                diferenca = diferenca + Math.Pow(num - media, 2);
            }
            double variancia = diferenca / numerosOrdenados.Count;
            double desvioPadrao = Math.Sqrt(variancia);

            //Moda de Pearson
            double modaPearson = 3 * mediana - (2 * media);

            // "F" retorna o número com duas casas decimais, e "C"retorna o número como um valor monetário.
            lbMaiorNumeroResult.Text = maximo.ToString();
            lbMenorNumeroResult.Text = minimo.ToString();
            lbModaResult.Text = valorModa;
            lbVarianciaResult.Text = variancia.ToString("F");
            lbDesvioPadraoResult.Text = desvioPadrao.ToString("F");
            lbModaPearsonResult.Text = modaPearson.ToString("F");
            lbMediaResult.Text = media.ToString("F");
            lbMedianaResult.Text = mediana.ToString("F");

            tbNumero.Focus();
        }

        private void tbNumero_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                btnAdicionar.PerformClick();
            }
        }

    }

}