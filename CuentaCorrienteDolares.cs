public class CuentaCorrienteDolares : CuentaBancaria {

  public int cantidadExtraida { get; set; }

  public CuentaCorrienteDolares() {
    cantidadExtraida = 0;
  }
  public void Extraccion(int monto, TipoExtraccion tipo) {
    if (monto + cantidadExtraida > 200 && tipo == TipoExtraccion.CajeroAutomatico)
    {
      Console.WriteLine("No puede extraer más de $200 por día");
      return;
    }

    cantidadExtraida += monto;
    Fondos -= monto;
  }
}