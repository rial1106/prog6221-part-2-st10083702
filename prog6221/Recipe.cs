﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace prog6221
{

    public delegate void AboveThresholdEventHandler(double value);

    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;

        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

        public List<String> Steps { get; set; } = new List<String> ();

        private double ScaleFactor = 1;

        // Delegate
        public event AboveThresholdEventHandler AboveThreshold;

        public Recipe(int id, string name)
        {
            Id = id;
            Name = name;
        }

        // The ToString is called on the object to display it in the list.
        public override string? ToString()
        {
            return Name;
        }

        // Count the total calories in all the ingredients.
        public double TotalCalories
        {
            get
            {
                double total = 0;
                foreach(var i in Ingredients)
                {
                    total += i.NumberOfCalories;
                }

                if (total > 300)
                {
                    AboveThreshold?.Invoke(total);
                }

                return total;
            }
        }
        public void AddIngredient(Ingredient ingredient)
        {
            Ingredients.Add(ingredient);
        }

        public void AddStep(String step)
        {
            Steps.Add(step);
        }

        public void ScaleRecipe(double factor)
        {
            ScaleFactor *= factor;
            foreach(Ingredient x in Ingredients)
            {
                x.Quantity *= factor;
            }

            scaleSteps(factor);


        }

        // Undo all scaling, note: scaling in compounding.
        public void ResetScaleRecipe()
        {
            foreach (Ingredient x in Ingredients)
            {
                x.Quantity /= ScaleFactor;
            }

            scaleSteps(1 / ScaleFactor);
            ScaleFactor = 1;
        }

        // Note: SCALING IS COMPOUNDING.
        private void scaleSteps(double scaleFactor)
        {

            List<String> NewStepsScaled = new List<String>();
            foreach (var step in Steps) // For each step.
            {
                /* 
                 * The following string is a regex pattern.
                 * \b matches a word boundary (start and end of a word).
                 * (?<!-) is a negative lookbehind. It ensures that we don't match
                 * negative numbers.
                 * \d+\.?\d* match a sequence of digits, followed by an optional
                 * dot character and 0 or more digits. We use this to detect a double.
                 * \w+ of \w+ detects 2 words seperated by the word 'of'.
                 * \b matches a word boundary (start and end of a word).
                 * 
                 * In the step:
                 * Add 1 bag of tea to 0.5 litres of water.
                 * 
                 * This pattern would match:
                 * 1 bag of tea as well as 0.5 litres of water.
                 */
                string pattern = @"\b(?<!-)(\d+\.?\d* \w+ of \w+)\b";

                /* Create a regular expression with insensitive case matching.
                 * Adapted from a StackOverflow answer.
                 * Author: stema
                 * Link: https://stackoverflow.com/a/11965836
                 */
                Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

                // Use regex.Matches incase there is more than one match in a line.
                var matches = regex.Matches(step);

                // This string holds a copy of the original step that we will be modifying.
                string newStep = step;

                foreach (Match match in matches) // Loop over each Match
                {
                    // Get the value ex. 0.5 litres of water
                    string strMatch = match.Value;

                    // Split the match on a whitespace ex. [0.5] [litres] [of] [water] 
                    string[] words = strMatch.Split(' ');

                    /*
                     * Convert the first word (quantity) to a double, we ensured
                     * that it is a valid double using the regex pattern.
                     */
                    double quantity = Convert.ToDouble(words[0]);

                    // Scale the quantity ex [0.5 * 4]
                    double newQuantity = quantity * scaleFactor;

                    // Recombine the string ex. [2 litres of water] 
                    newStep = newStep.Replace(strMatch, newQuantity.ToString() +
                        ' ' + words[1] +
                        ' ' + words[2] +
                        ' ' + words[3]
                        );

                }

                NewStepsScaled.Add(newStep);
            }

            Steps = NewStepsScaled;
        }


    }
}
