package com.example.omegatechapi;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.EnableAutoConfiguration;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.annotation.ComponentScan;
import org.springframework.context.annotation.Configuration;
import org.springframework.scheduling.annotation.EnableAsync;

@SpringBootApplication
@Configuration
//@EnableAutoConfiguration
//@ComponentScan
@EnableAsync
public class OmegatechapiApplication {

	public static void main(String[] args) {
		SpringApplication.run(OmegatechapiApplication.class, args);
	}

}
