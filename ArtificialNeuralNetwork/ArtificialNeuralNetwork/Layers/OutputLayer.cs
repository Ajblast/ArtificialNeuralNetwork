using System;
using System.Collections.Generic;
using System.Text;

namespace ArtificialNeuralNetwork
{
    public sealed class OutputLayer : NeuralLayer
    {
        public OutputLayer (int numberInputs, int numberNeurons, Func<double, double> activationFunction)
        {
            neurons = new Neuron[numberNeurons];

            inputs = new double[numberInputs];
            outputs = new double[numberNeurons];

            Init();
        }
        protected override void Init()
        {
            for (int i = 0; i < neurons.Length; i++)
            {
                neurons[i] = new Neuron(inputs.Length, activationFunction);
            }
        }
    }
}
