//Aluno: Tiago Grossi Hasuda
//RA: 1694324

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_Extra_AFD
{
    public partial class AFD : Form
    {
        public AFD()
        {
            InitializeComponent();
        }

        private class State
        {
            public string Name;
            public string a;
            public string b;
            public bool Aceitador;

            public State(string name, string _a, string _b, bool _aceitador)
            {
                Name = name;
                a = _a;
                b = _b;
                Aceitador = _aceitador;
            }
        }

        List<string> EstadosAceitadoresAll = new List<string>();
        string EstadoDeInicio;

        private void btnReduce_Click(object sender, EventArgs e)
        {
            groupInput.Enabled = false;
            Organizar();
            groupInput.Enabled = true;
        }

        private void Organizar()
        {
            EstadoDeInicio = dataInput.Rows[0].Cells[0].Value.ToString();

            List<State> Estados = new List<State>();
            foreach(DataGridViewRow row in dataInput.Rows)
            {
                if (row.Cells[0].Value == null) continue;
                State newState = new State(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value != null);
                if (row.Cells[3].Value != null) EstadosAceitadoresAll.Add(row.Cells[0].Value.ToString());
                Estados.Add(newState);
            }

            ReduzirAFD(Estados);
        }

        private void ReduzirAFD(List<State> Estados)
        {
            //Criar lista que sera os estados finais
            List<List<State>> EstadosFinais = new List<List<State>>();
            //Adicionar um estado aceitador e um não aceitador
            EstadosFinais.Add(new List<State>());
            EstadosFinais.Add(new List<State>());

            List<string[]> NomeEstados;

            //Preencher os estados aceitadores e não aceitadores
            foreach (State estado in Estados)
            {
                if (estado.Aceitador) EstadosFinais[0].Add(estado);
                else EstadosFinais[1].Add(estado);
            }

            int t1, t2;

            //Criar uma lista de estados para comparar com a original no final
            List<List<State>> AllStates = new List<List<State>>();

            AllStates = EstadosFinais;
            EstadosFinais = new List<List<State>>();

            //While para verificar se houve mudanças após passar pela verificação
            while (AllStates.Count != EstadosFinais.Count)
            {
                EstadosFinais = AllStates;
                AllStates = new List<List<State>>();

                //Criar uma lista de strings com os nomes dos estados em cada grupo para melhor identificação
                NomeEstados = GetNomeEstados(EstadosFinais);

                //Neste for eu passo por cada grupo de estados e verifico se eles são equivalentes
                for (t1 = 0; t1 < EstadosFinais.Count; t1++)
                {
                    if (EstadosFinais[t1].Count == 1)
                    {
                        List<State> singleState = new List<State>();
                        singleState.Add(EstadosFinais[t1][0]);
                        AllStates.Add(singleState);
                        continue;
                    }

                    State nextJump = EstadosFinais[t1][0];

                    List<List<State>> newState = new List<List<State>>();

                    List<State> stateTemp;
                    bool changed = true;

                    //Este while se repete sempre que um ou mais estados não forem equivalentes, criando mais estados no resultado final
                    while (changed)
                    {
                        changed = false;
                        stateTemp = new List<State>();
                        stateTemp.Add(nextJump);

                        //Este for compara todos os estados para verem se são equivalentes
                        for (t2 = 1; t2 < EstadosFinais[t1].Count; t2++)
                        {
                            if ((EstadosFinais[t1][t2].a == nextJump.a && (EstadosFinais[t1][t2].b == nextJump.b || NomeEstados[t1].Contains(EstadosFinais[t1][t2].b))) ||
                                (EstadosFinais[t1][t2].b == nextJump.b && (EstadosFinais[t1][t2].a == nextJump.a || NomeEstados[t1].Contains(EstadosFinais[t1][t2].a))))
                            {
                                stateTemp.Add(EstadosFinais[t1][t2]);
                            }
                            else
                            {
                                if (!changed)
                                {
                                    nextJump = EstadosFinais[t1][t2];
                                    changed = true;
                                }
                            }
                        }
                        foreach (State remove in stateTemp) EstadosFinais[t1].Remove(remove);
                        newState.Add(stateTemp);
                    }
                    foreach (List<State> lista in newState) AllStates.Add(lista);
                }
            }

            //A partir daqui é somente instruções para mostrar os dados ao usuário, o resultado final está guardado na variável 'AllStates'
            dataOutput.Rows.Clear();
            
            NomeEstados = GetNomeEstados(AllStates);

            string output0, output1, output2;
            bool output3;

            //As variáveis 'EstadoDeInicio' e 'EstadosAceitadoresAll' são variáveis globais setadas imediatamente antes dessa função('ReduzirAFD')
            for(t1 = 0; t1 < AllStates.Count; t1++)
            {
                output3 = false;

                if (NomeEstados[t1].Contains(EstadoDeInicio)) output0 = AllStates[t1][0].Name + "(Inicial)";
                else output0 = AllStates[t1][0].Name;

                if (NomeEstados[t1].Contains(AllStates[t1][0].a))
                    output1 = AllStates[t1][0].Name;
                else
                    output1 = ProcurarEstado(NomeEstados, AllStates[t1][0].a);

                if (NomeEstados[t1].Contains(AllStates[t1][0].b))
                    output2 = AllStates[t1][0].Name;
                else
                    output2 = ProcurarEstado(NomeEstados, AllStates[t1][0].b);

                foreach (string st in NomeEstados[t1])
                {
                    if (EstadosAceitadoresAll.Contains(st)) output3 = true;
                    break;
                }

                dataOutput.Rows.Add(output0, output1, output2, output3);
            }
        }

        private string ProcurarEstado(List<string[]> nomes, string state)
        {
            foreach (string[] states in nomes)
                if (states.Contains(state)) return states[0];

            return null;
        }

        private List<string[]> GetNomeEstados(List<List<State>> Estados)
        {
            List<string[]> NomeEstados = new List<string[]>();

            string[] temp;

            int count;

            foreach(List<State> lista in Estados)
            {
                temp = new string[lista.Count];

                for (count = 0; count < lista.Count; count++)
                    temp[count] = lista[count].Name;

                NomeEstados.Add(temp);
            }

            return NomeEstados;
        }
    }
}

//Aluno: Tiago Grossi Hasuda
//RA: 1694324