public class CuentaBancaria {
  public int Fondos { get; set; }

  public void Insercion(int monto) {
    Fondos += monto;
  }

  public void Extraccion(int monto, TipoExtraccion tipo) {

  }
}