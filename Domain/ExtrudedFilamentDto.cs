namespace APIFilamentoExtruido.Domain;

public class ExtrudedFilamentDto
{
    public string Name { get; set; }
    public int SpeedMotor { get; set; }
    public bool StateMaterial { get; set; }
    public bool EnableMotor { get; set; }
    public float CollectMeters { get; set; }
    public float ExtruderTemperature { get; set; }
    public float SetPointTemperature { get; set; }
}

public class ExtrudedFilamentDtoUpdate
{
    public int? SpeedMotor { get; set; }
    public bool? StateMaterial { get; set; }
    public bool? EnableMotor { get; set; }
    public float? CollectMeters { get; set; }
    public float? ExtruderTemperature { get; set; }
    public float? SetPointTemperature { get; set; }
}