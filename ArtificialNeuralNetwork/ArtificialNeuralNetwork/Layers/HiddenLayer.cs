using System;
using System.Collections.Generic;
using System.Text;

namespace ArtificialNeuralNetwork
{
    public sealed class HiddenLayer : NeuralLayer
    {
        public HiddenLayer (int numberInputs, int numberNeurons, Func<double, double> activationFuction)
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
