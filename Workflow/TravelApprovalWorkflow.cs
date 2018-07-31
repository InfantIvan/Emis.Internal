using System;
using System.Collections.Generic;
using System.Text;
using tomware.Microwf.Core;

namespace Emis.Internal.Travel.Workflow
{
	public class TravelApprovalWorkflow : WorkflowDefinitionBase
	{
		public const string TYPE = "TravelApprovalWorkflow";
		public override string Type
		{
			get { return TYPE; }
		}

		public override List<Transition> Transitions => throw new NotImplementedException();
	}
}
