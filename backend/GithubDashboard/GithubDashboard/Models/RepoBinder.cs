﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GithubDashboard.Models
{
    public class RepoBinder : IModelBinder
    {

        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            if (bindingContext == null)
            {
                throw new ArgumentNullException(nameof(bindingContext));
            }

            // Try to fetch the value of the argument by name
            var valueProviderResult = bindingContext.ValueProvider
                .GetValue(bindingContext.ModelName);

            if (valueProviderResult == ValueProviderResult.None)
            {
                return Task.CompletedTask;
            }

            var json = valueProviderResult.FirstValue;

            // Check if the argument value is null or empty
            if (string.IsNullOrEmpty(json))
            {
                return Task.CompletedTask;
            }

            //Try to parse the provided value into the desired model
            var model = JsonConvert.DeserializeObject<Repos>(json);

            //Model will be null if unable to desrialize.
            if (model == null)
            {
                bindingContext.ModelState
                    .TryAddModelError(
                        bindingContext.ModelName,
                        "Invalid data"
                    );
                return Task.CompletedTask;
            }

            //bindingContext.ModelState.SetModelValue(bindingContext.ModelName, model);

            //could consider checking model state if so desired.

            //set result state of binding the model
            bindingContext.Result = ModelBindingResult.Success(model);
            return Task.CompletedTask;
        }
    }
}
