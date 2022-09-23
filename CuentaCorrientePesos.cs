public class CuentaCorrientePesos : CuentaBancaria {
  public void Extraccion(int monto, TipoExtraccion tipo) {
    if (Fondos - monto < -5000) {
      Console.WriteLine("No puede extraer más dinero.");
      return;
    };

    if (monto > 20000 && tipo == TipoExtraccion.CajeroAutomatico)
    {
      Console.WriteLine("No puede extraer más de $20000");
      return;
    }

    Fondos -= monto;
  }
}