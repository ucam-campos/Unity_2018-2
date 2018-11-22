public static class Pontuacao{
	static int pontos;

	public static int getPontos(){
		return pontos;
	}

	public static void incrementa(){
		pontos++;
	}

	public static void zera(){
		pontos = 0;
	}
}
