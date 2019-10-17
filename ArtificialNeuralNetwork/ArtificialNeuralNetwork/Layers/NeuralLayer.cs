using System;
using System.Collections.Generic;

namespace ArtificialNeuralNetwork
{
    public abstract class NeuralLayer
    {
        protected Neuron[] neurons;
        public double[] inputs;
        public double[] outputs;

        protected Func<double, double> activationFunction;

        public NeuralLayer previousLayer;
        public NeuralLayer nextLayer;

        public int NeuronCount { get { return neurons.Length; } }

        protected NeuralLayer(int numberInputs, int numberNeurons, Func<double, double> activationFunction)
        {
            neurons = new Neuron[numberNeurons];

            inputs = new double[numberInputs];
            outputs = new double[numberNeurons];

            for (int i = 0; i < neurons.Length; i++)
            {
                neurons[i] = new Neuron(inputs.Length, activationFunction);
            }
        }

        public void Calc()
        {
            for (int i = 0; i < neurons.Length; i++)
            {
                neurons[i].inputs = inputs;
                neurons[i].Calculate();
                outputs[i] = neurons[i].Output;
            }
        }
    }
}
