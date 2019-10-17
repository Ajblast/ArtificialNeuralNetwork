using System;
using System.Collections.Generic;
using System.Text;

namespace ArtificialNeuralNetwork
{
    public sealed class OutputLayer : NeuralLayer
    {
        public OutputLayer(int numberInputs, int numberNeurons, Func<double, double> activationFunction) : base(numberInputs, numberNeurons, activationFunction) { }

    }
}
