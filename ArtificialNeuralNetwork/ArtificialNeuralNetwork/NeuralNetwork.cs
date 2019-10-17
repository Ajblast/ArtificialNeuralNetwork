using System;
using System.Collections.Generic;
using System.Text;

namespace ArtificialNeuralNetwork
{
    public sealed class NeuralNetwork
    {
        private InputLayer inputLayer;
        private List<HiddenLayer> hiddenLayers;
        public OutputLayer outputLayer { get; private set;}

        public int NumberInputs { get { return inputLayer.NeuronCount; } }
        public int NumberOutputs { get { return outputLayer.NeuronCount; } }

        public NeuralNetwork(int numberInputs, int numberOutputs, int[] numberOfHiddenNeurons, Func<double, double>[] hiddenActivationFunctions, Func<double, double> outputActivationFunction)
        {
            inputLayer = new InputLayer(numberInputs);

            hiddenLayers = new List<HiddenLayer>();
            for (int i = 0; i < numberOfHiddenNeurons.Length; i++)
            {
                int hiddenNumberInputs = i == 0 ? numberInputs : numberOfHiddenNeurons[i - 1];

                HiddenLayer hidden = new HiddenLayer(hiddenNumberInputs, numberOfHiddenNeurons[i], hiddenActivationFunctions[i]);
                hiddenLayers.Add(hidden);

                if (i == 0)
                {
                    // This is the first hidden layers, as such, the previous layer is the input layer
                    inputLayer.nextLayer = hidden;
                    hidden.previousLayer = inputLayer;
                }
                else
                {
                    hiddenLayers[i - 1].nextLayer = hidden;
                    hidden.previousLayer = hiddenLayers[i - 1];
                }
            }

            if (numberOfHiddenNeurons.Length == 0)
            {
                outputLayer = new OutputLayer(numberInputs, numberOutputs, outputActivationFunction);
                outputLayer.previousLayer = inputLayer;
                inputLayer.nextLayer = outputLayer;
            }
            else
            {
                HiddenLayer hiddenLayer = hiddenLayers[hiddenLayers.Count - 1];

                outputLayer = new OutputLayer(hiddenLayer.NeuronCount, numberOutputs, outputActivationFunction);
                outputLayer.previousLayer = hiddenLayer;
                hiddenLayer.nextLayer = outputLayer;
            }
        }

        public double[] Calc(double[] inputs)
        {
            inputLayer.inputs = inputs;
            inputLayer.Calc();

            for (int i = 0; i < hiddenLayers.Count; i++)
            {
                hiddenLayers[i].inputs = hiddenLayers[i].previousLayer.outputs;
                hiddenLayers[i].Calc();
            }

            outputLayer.inputs = outputLayer.previousLayer.outputs;
            outputLayer.Calc();

            return (double[]) outputLayer.outputs.Clone();
        }
    }
}
