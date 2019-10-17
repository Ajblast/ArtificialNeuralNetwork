using System;
using System.Collections.Generic;
using System.Text;

namespace ArtificialNeuralNetwork
{
    public abstract class LearningAlgorithm
    {
        protected NeuralNetwork neuralNetwork;

        public LearningMode LearningMode;
        protected LearningParadigm learningParadigm;

        public int MaxEpochs { get; protected set; }
        protected int currentEpoch = 0;

        public double MinimumOverallErrorThreshold { get; protected set; }
        public double LearningRate { get; protected set; }

        public abstract void Train();
        public abstract void FeedForward(double[] inputs);

        protected abstract void ApplyNewWeights();
        public abstract double CalculateNewWeight(int layer, int input, int neuron);
        public abstract double CalculateNewWeight(int layer, int input, int neuron, double error);
    }
}
