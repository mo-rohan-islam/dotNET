package com.rohan.trainings.servlets.listener;

import jakarta.servlet.ServletRequestEvent;
import jakarta.servlet.ServletRequestListener;

/**
 * Application Lifecycle Listener implementation class RequestListener
 *
 */
public class RequestListener implements ServletRequestListener {

	public void requestDestroyed(ServletRequestEvent event) {
		System.out.println("Request Destroyed");
	}

	public void requestInitialized(ServletRequestEvent event) {
		System.out.println("Request Created");
	}

}
