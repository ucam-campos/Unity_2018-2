
public static class Pontuacao {
	public static int pontos;
	
	public static void AddPonto(){
		pontos++;
	}

	public static int GetPonto(){
		return pontos;
	}

	public static void ZerarPonto(){
		pontos = 0;
	}
}
