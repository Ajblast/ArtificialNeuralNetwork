using System;
using System.Collections.Generic;

namespace ArtificialNeuralNetwork
{
    public class Neuron
    {
        protected List<double> weights;
        private List<double> inputs;

        private double output;
        private double preOutput;

        protected double bias = 1;

        private Func<double, double> activationFunction;

        public Neuron(int numberInputs, Func<double, double> activationFunction)
        {
            weights = new List<double>(numberInputs + 1);
            inputs = new List<double>(numberInputs);

            this.activationFunction = activationFunction;

            Initialize();
        }

        private void Initialize()
        {
            System.Random random = new Random();
            for (int i = 0; i < weights.Count; i++)
            {
                weights[i] = random.NextDouble();
            }
        }
    }
}
