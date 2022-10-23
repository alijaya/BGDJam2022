using System;
using UnityEngine;

public class Skill
{
    public int idx { get; set; }
    public string name { get; set; }
    public string skillDescription { get; set; }
    public string modOperation { get; set; }
    public int modValue { get; set; }
    public int reqType { get; set; } //1 none, 2 odd, 3 even, 4 number, 5 upper limit on damage
    public int reqValue { get; set; }
    public string reqDescription { get; set; }
    public bool isHeal { get; set; }
    public bool isReroll { get; set; }
    public bool isFixedDamage { get; set; }
}