public class CajaDeAhorros : CuentaBancaria {
  public void Extraccion(int monto, TipoExtraccion tipo) {
    if (Fondos < monto) {
      Console.WriteLine("Fondos insuficientes");
      return;
    };

    if (monto > 1000 && tipo == TipoExtraccion.CajeroAutomatico)
    {
      Console.WriteLine("No puede extraer más de $10000");
      return;
    }

    Fondos -= monto;
  }
}