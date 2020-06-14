using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gymrat.Component.Rat
{
    public class RatViewModelInputType : InputObjectType<RatViewModel>
    {
        protected override void Configure(IInputObjectTypeDescriptor<RatViewModel> descriptor)
        {
            descriptor.Field(t => t.EmailId).Type<NonNullType<StringType>>();
        }
    }
}
