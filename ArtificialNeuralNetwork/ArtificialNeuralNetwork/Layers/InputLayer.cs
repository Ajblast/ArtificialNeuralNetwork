using System;
using System.Collections.Generic;

namespace ArtificialNeuralNetwork
{
    public sealed class InputLayer : NeuralLayer
    {
        public InputLayer(int numberInputs)
        {
            neurons = new Neuron[numberInputs];

            inputs = new double[numberInputs];
            outputs = new double[numberInputs];

            Init();
        }

        protected override void Init()
        {
            for (int i = 0; i < neurons.Length; i++)
            {
                neurons[i] = new Neuron(0, activationFunction);
            }
        }

        protected override void Calc()
        {
            for (int i = 0; i < neurons.Length; i++)
            {
                neurons[i].inputs = this.inputs;
                neurons[i].Calculate();
            }
        }
    }
}
