using System;
using System.Collections.Generic;
using System.Text;

namespace ArtificialNeuralNetwork
{
    public sealed class HiddenLayer : NeuralLayer
    {
        public HiddenLayer(int numberInputs, int numberNeurons, Func<double, double> activationFuction) : base(numberInputs, numberNeurons, activationFuction) { }
    }
}
