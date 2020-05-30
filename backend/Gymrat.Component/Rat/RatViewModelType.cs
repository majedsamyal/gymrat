using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gymrat.Component.Rat
{
   public class RatViewModelType : ObjectType<RatViewModel>
    {
        protected override void Configure(IObjectTypeDescriptor<RatViewModel> descriptor)
        {
            descriptor.Field(t => t.Id)
                .Type<NonNullType<IdType>>();
        }
        
    }
}
