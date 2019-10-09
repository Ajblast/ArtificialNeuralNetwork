using System;
using System.Collections.Generic;

namespace ArtificialNeuralNetwork
{
    public class Neuron
    {
        public double[] inputs;
        public double[] weights;

        public double Output { get; private set; }

        protected double bias = 1;

        private Func<double, double> activationFunction;

        public Neuron(int numberInputs, Func<double, double> activationFunction)
        {
            weights = new double[numberInputs + 1];
            inputs = new double[numberInputs];

            this.activationFunction = activationFunction;

            Initialize();
        }

        private void Initialize()
        {
            System.Random random = new Random();
            for (int i = 0; i < weights.Length; i++)
            {
                weights[i] = random.NextDouble();
            }
        }

        public void Calculate()
        {
            double preOutput = 0;
            if (inputs.Length > 0)
            {
                if (inputs != null && weights != null)
                {
                    for (int i = 0; i < weights.Length; i++)
                    {
                        preOutput += ((i == weights.Length) ? bias : inputs[i]) * weights[i];
                    }
                }
            }

            Output = activationFunction(preOutput);
        }
    }
}
