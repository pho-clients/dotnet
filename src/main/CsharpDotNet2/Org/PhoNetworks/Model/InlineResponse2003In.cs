using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.PhoNetworks.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class InlineResponse2003In {
    /// <summary>
    /// Gets or Sets _5f9e769ff6fe4cee02b3b4547200db6b
    /// </summary>
    [DataMember(Name="5f9e769ff6fe4cee02b3b4547200db6b", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "5f9e769ff6fe4cee02b3b4547200db6b")]
    public NodeEdge _5f9e769ff6fe4cee02b3b4547200db6b { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InlineResponse2003In {\n");
      sb.Append("  _5f9e769ff6fe4cee02b3b4547200db6b: ").Append(_5f9e769ff6fe4cee02b3b4547200db6b).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
