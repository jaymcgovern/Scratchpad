from django.http import HttpResponse

def hello(request):
	return HttpResponse("Hello, Jay!!!")

def scratchpad(request):
	return HttpResponse("<h1>Welcome to Scratchpad!</h1>")