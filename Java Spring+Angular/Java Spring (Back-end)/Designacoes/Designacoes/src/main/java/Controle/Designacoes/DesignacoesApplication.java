package Controle.Designacoes;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.annotation.Bean;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.servlet.config.annotation.CorsRegistry;
import org.springframework.web.servlet.config.annotation.WebMvcConfigurer;
@RestController
@SpringBootApplication
public class DesignacoesApplication {

	public static void main(String[] args) {
		SpringApplication.run(DesignacoesApplication.class, args);
	}

	//configuracoes referente ao Angular
	@Bean
	public WebMvcConfigurer corsConfigurer() {
		return new WebMvcConfigurer() {
			@Override
			public void addCorsMappings(CorsRegistry registry) {
				registry.addMapping("/**")
				.allowedMethods("DELETE","GET", "POST", "PUT")
				.allowedOrigins("*");
			}
		};
	}
}
