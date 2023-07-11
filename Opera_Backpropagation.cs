using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Practica_7_BackPropagation
{
   
    public class Opera_Backpropagation
    {
        List<Layer> CAPAS;
        List<double[,]> deltas;//Arreglo de listas para las deltas
        static public double Contador = 0,Epocas, mostEpocas;
        static public double mostError;
        
        //Aqui recive todos los datos las matrices de entrada, la salida esperada, el valor de razon de aprendizaje,el mazimo error 
        public void Aprender(List<double[]> input, List<double[]> desiredOutput, double alpha, double maxError)
        {
            //double epocas = Epocas;//Varibale que viene desde el Texbox para la cantidad de iteraciones
            double epocas = 998;                              //epocas
            leererror = new List<string>();
            
            while (epocas > maxError)
            {
                Contador++;
                BackPropagation(input, desiredOutput, alpha);
                epocas = GeneralError(input, desiredOutput);
                leererror.Add(epocas.ToString());
                if(Contador == Epocas)
                {
                    break;
                }
                mostEpocas=Contador+2;
                //Console.WriteLine(epocas);
            }
            mostError = epocas;
        }
        
        public Opera_Backpropagation(int[] neuronasporcapa)
        {
            CAPAS = new List<Layer>();
            Random r = new Random();

            for (int i = 0; i < neuronasporcapa.Length; i++)
            {
                //porcada neurona por capa se crea una capa o sequita la neurona que esta atras
                CAPAS.Add(new Layer(neuronasporcapa[i], i == 0 ? neuronasporcapa[i] : neuronasporcapa[i - 1], r));
            }
        }
        public double[] Activate(double[] ENTRADAS)//PAra la activacion va a tomar desde la capa 0 a la ultima
        {
            double[] SALIDAS = new double[0];//SAlidada de la capa 0
            for (int i = 0; i < CAPAS.Count; i++)
            {
                SALIDAS = CAPAS[i].Activate(ENTRADAS);//La capa de salida es donde se guarda la capa que ya se havia activado
                                                      //y va tomando de capa en capa hasta llegar a la ultima
                ENTRADAS = SALIDAS;
            }
            return SALIDAS;
        }
        //Aqui se hace lo del erro cuadratico medio con la funcion Math
        double IndividualError(double[] SALIDAREAL, double[] SALIDADESEADA)
        {
            double err = 0;
            for (int i = 0; i <SALIDAREAL.Length; i++)
            {
                err += Math.Pow(SALIDAREAL[i] - SALIDADESEADA[i], 2);//Aqui es a salida real - la salida deseada al cuadrado
            }
            return err;
        }
        double GeneralError(List<double[]> entrada, List<double[]> salidaDeseada)//Aqui el otro porcentaje de error general de toda la red
        {
            double error = 0;
            for (int i = 0; i < entrada.Count; i++)
            {
                error += IndividualError(Activate(entrada[i]), salidaDeseada[i]);
            }
            return error;
        }


        List<string> leererror;
        List<double[]> sumas;//Listas para las sigmas 

        void Sumas(double[] desiredOutput)//Aqui se hace la dimension de que cada peso tengoa una Suma
        {
            sumas = new List<double[]>();
            for (int i = 0; i < CAPAS.Count; i++)
            {
                sumas.Add(new double[CAPAS[i].numberOfNeurons]);
            }
            for (int i = CAPAS.Count - 1; i >= 0; i--)
            {
                for (int j = 0; j < CAPAS[i].numberOfNeurons; j++)
                {
                    if (i == CAPAS.Count - 1)
                    {
                        //Aqui hace la parte dela paso 4.1 de calcular las deltas de la capa de salida
                        double y = CAPAS[i].neurons[j].ultimaActivacion;
                        sumas[i][j] = (Neuron.Sigmoide(y) - desiredOutput[j]) * Neuron.ActivacionSigmoide(y);
                    }
                    else
                    {
                        double sum = 0;
                        for (int k = 0; k < CAPAS[i + 1].numberOfNeurons; k++)
                        {
                            //Aqui se hace el paso 4.2 de calcular las deltas de las capas ocultas y de como regreesa
                            sum += CAPAS[i + 1].neurons[k].pesos[j] * sumas[i + 1][k];
                        }
                        sumas[i][j] = Neuron.ActivacionSigmoide(CAPAS[i].neurons[j].ultimaActivacion) * sum;
                    }
                }
            }
        }
        void Deltas()//Para cada peso un delta
        {
            deltas = new List<double[,]>();
            for (int i = 0; i < CAPAS.Count; i++)
            {
                deltas.Add(new double[CAPAS[i].numberOfNeurons, CAPAS[i].neurons[0].pesos.Length]);
            }
        }
        void AgregarDelta()
        {
            for (int i = 1; i < CAPAS.Count; i++)
            {
                for (int j = 0; j < CAPAS[i].numberOfNeurons; j++)
                {
                    for (int k = 0; k < CAPAS[i].neurons[j].pesos.Length; k++)
                    {
                        deltas[i][j, k] += sumas[i][j] * Neuron.Sigmoide(CAPAS[i - 1].neurons[k].ultimaActivacion);
                    }
                }
            }
        }
        void ActualizacionUmbrales(double alpha)
        {
            for (int i = 0; i < CAPAS.Count; i++)
            {
                for (int j = 0; j < CAPAS[i].numberOfNeurons; j++)
                {
                    CAPAS[i].neurons[j].bias -= alpha * sumas[i][j];
                }
            }
        }
        void ActualizacionPESOS(double alpha)//Aqui se hace la asignacion de cada peso a las neuronas
        {
            for (int i = 0; i < CAPAS.Count; i++)
            {
                for (int j = 0; j < CAPAS[i].numberOfNeurons; j++)
                {
                    for (int k = 0; k < CAPAS[i].neurons[j].pesos.Length; k++)
                    {
                        CAPAS[i].neurons[j].pesos[k] -= alpha * deltas[i][j, k];
                    }
                }
            }
        }
        //Aqui hace la actualizacion de los pesos y los umbrales de las entradas, con la comparacion de salida
        void BackPropagation(List<double[]> input, List<double[]> desiredOutput, double alpha)
        {
            Deltas();
            for (int i = 0; i < input.Count; i++)
            {
                Activate(input[i]);
                Sumas(desiredOutput[i]);
                ActualizacionUmbrales(alpha);
                AgregarDelta();
            }
            ActualizacionPESOS(alpha);
        }
    }


    class Layer
    {
        public List<Neuron> neurons;
        public int numberOfNeurons;
        public double[] output;

        public Layer(int _numberOfNeurons, int numberOfInputs, Random r)
        {
            numberOfNeurons = _numberOfNeurons;   //
            neurons = new List<Neuron>();
            for (int i = 0; i < numberOfNeurons; i++)
            {
                neurons.Add(new Neuron(numberOfInputs, r));
            }
        }
        public double[] Activate(double[] inputs)
        {
            List<double> outputs = new List<double>();
            for (int i = 0; i < numberOfNeurons; i++)
            {
                outputs.Add(neurons[i].Activate(inputs));
            }
            output = outputs.ToArray();
            return outputs.ToArray();
        }
    }
    class Neuron
    {
        public double[] pesos;
        public double ultimaActivacion;
        public double bias;
        public Neuron(int numberOfInputs, Random r)
        {
            bias = 10 * r.NextDouble() - 5;
            pesos = new double[numberOfInputs];
            for (int i = 0; i < numberOfInputs; i++)
            {
                pesos[i] = 10*r.NextDouble()-5;
            }
        }
        public double Activate(double[] inputs)//Activacion de pesos de cada neurona
        {
            double activation = bias;

            for (int i = 0; i < pesos.Length; i++)
            {
                activation += pesos[i] * inputs[i];
            }

            ultimaActivacion = activation;
            return Sigmoide(activation);
        }
        public static double Sigmoide(double input)
        {
            return 1 / (1 + Math.Exp(-input));//Funcion de activacion sigmoidal
        }
        public static double ActivacionSigmoide(double input)
        {
            double y = Sigmoide(input);
            return y * (1 - y);
        }
    }
}
