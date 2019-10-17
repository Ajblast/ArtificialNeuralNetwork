using System;
using System.Collections.Generic;

namespace ArtificialNeuralNetwork
{
    public sealed class InputLayer : NeuralLayer
    {
        public InputLayer(int numberInputs) : base(numberInputs, numberInputs, (d) => { return d; }) { }
    }
}
