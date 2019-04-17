from pexpect import pxssh
#Inicia un nuevo cliente para ingresar#
def __init__(self, host, user, password):
	self.host = host#Ip
	self.user = user#Nombre de Maquina
	self.password = password#Contraseña si la hay
	self.session = self.ssh()#Inicio de sesión desde 0

def ssh(self):
	try:
		bot = pxssh.pxssh()
		bot.login(self.host, self.user, self.password)
		return bot

	except Exception as e:
		print('Connection Error')
		print(e)


def send_command(self, cmd):
	self.session.sendline(cmd)
	self.session.prompt()
	return self.session.before

def command_bots(command):
	for bot in botnet:
		attack = botnet.send_command(command)
		print('Output from ' +bot.host)
		print(attack)

botnet = []

def add_bot(host, user, password):
	new_bot = bot(host, user, password)
	botnet.append(new_bot)

add_bot('10.0.0.59', '', '')

command_bots('ls')