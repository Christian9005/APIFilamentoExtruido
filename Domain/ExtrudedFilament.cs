using System.ComponentModel.DataAnnotations;

namespace APIFilamentoExtruido.Domain;

public class ExtrudedFilament
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public int SpeedMotor { get; set; }
    public bool StateMaterial { get; set; }
    public float CollectMeters { get; set; }
    public float ExtruderTemperature { get; set; }
    public float SetPointTemperature { get; set; }
}
