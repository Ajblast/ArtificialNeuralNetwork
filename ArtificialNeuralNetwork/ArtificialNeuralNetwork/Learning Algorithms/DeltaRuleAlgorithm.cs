using System;
using System.Collections.Generic;
using System.Text;

namespace ArtificialNeuralNetwork
{
    public sealed class DeltaRuleAlgorithm : LearningAlgorithm
    {
        public double[][] Error;
        public double[] GeneralError;
        public double[] OverallError;

        public double OverallGeneralError;
        public double DegreeGeneralError = 2;
        public double DegreeOverallError = 0;

        public ErrorMeasurement GeneralErrorMeasurement = ErrorMeasurement.SQUARE_ERROR;
        public ErrorMeasurement OverallErrorMeasurement = ErrorMeasurement.MSE;

        private int currentRecord = 0;
        private double[][][] newWeights;

        public DeltaRuleAlgorithm()
        {

        }

        public override double CalculateNewWeight(int layer, int input, int neuron)
        {
            //double deltaWeight = LearningRate;

            //Neuron currentNeuron = neuralNetwork.outputLayer[neuron];
            //switch (LearningMode)
            //{
            //    case LearningMode.ONLINE:
            //        break;
            //    case LearningMode.BATCH:
            //     //   List<double> derivativeResult = currentNeuron.DerrivativeBatch(TrainingDate.getInputData());
            //        List<double> ith_input;
            //        break;
            //    default:
            //        break;
            //}
            throw new NotImplementedException();
        }

        public override double CalculateNewWeight(int layer, int input, int neuron, double error)
        {
            throw new NotImplementedException();
        }

        public override void FeedForward(double[] inputs)
        {
            throw new NotImplementedException();
        }

        public override void Train()
        {
            switch (LearningMode)
            {
                case LearningMode.ONLINE:
                    break;
                case LearningMode.BATCH:
                    currentEpoch = 0;
                    //FeedForward();
                    while (currentEpoch < MaxEpochs && OverallGeneralError > MinimumOverallErrorThreshold)
                    {
                        currentEpoch++;
                        for (int j = 0; j < neuralNetwork.NumberOutputs; j++)
                        {
                            for (int i = 0; i < neuralNetwork.NumberInputs; i++)
                            {
                                newWeights[0][j][i] = CalculateNewWeight(0, i, j);
                            }
                        }

                        ApplyNewWeights();
                        //FeedForward();
                    }
                    break;
                default:
                    currentEpoch = 0;
                    int k = 0;
                    currentRecord = 0;

                    //FeedForward(k);

                    while (currentEpoch < MaxEpochs && OverallGeneralError > MinimumOverallErrorThreshold)
                    {
                        for (int j = 0; j < neuralNetwork.NumberOutputs; j++)
                        {
                            for (int i = 0; i < neuralNetwork.NumberInputs; i++)
                            {
                                newWeights[0][j][i] = CalculateNewWeight(0, i, j);
                            }
                        }

                        ApplyNewWeights();
                        currentRecord = ++k;

                        //if(k >= trainingDate.numberRecords)
                        //{
                        //    k = 0;
                        //    currentRecord = 0;
                        //    currentEpoch++;
                        //}

                        FeedForward(k);
                    }

                    break;
            }
        }

        protected override void ApplyNewWeights()
        {
            throw new NotImplementedException();
        }
    }
}
