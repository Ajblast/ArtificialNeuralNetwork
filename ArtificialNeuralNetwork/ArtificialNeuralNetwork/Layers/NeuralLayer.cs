using System;
using System.Collections.Generic;

namespace ArtificialNeuralNetwork
{
    public abstract class NeuralLayer
    {
        protected Neuron[] neurons;
        protected double[] inputs;
        protected double[] outputs;

        protected Func<double, double> activationFunction;

        protected NeuralLayer previousLayer;
        protected NeuralLayer nextLayer;

        protected abstract void Init();
        protected abstract void Calc();
    }
}
