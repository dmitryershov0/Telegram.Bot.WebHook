### Replace token
Сначала вам нужно установить собственный токен в **appsettings.json**. Для этого замените **<BotToken>** в  **appsettings.json** на токен, принадлежащий вашему боту. 
Приставку "bot" добавлять не нужно.
```
"BotConfiguration": {
    "BotToken": "<BotToken>"    
  }
```
### Ngrok
Ngrok дает вам возможность получить доступ к вашему локальному компьютеру из временного поддомена, предоставленного ngrok. Этот домен может позже отправить в API Telegram как URL для webhook.
[Ngrok - download](https://ngrok.com/download)
```

and start ngrok on port 8443.
```
ngrok http 8443 -host-header="localhost:8443"
```
Telegram API поддерживает только порты 443, 80, 88 или 8443. В конфиге проекта устанавливаем порт 8443.

### Set Webhook
https://api.telegram.org/bot{token}/setWebhook?url={https://yoursubdomain.ngrok.io/api/update}

### Check Webhook
https://api.telegram.org/bot{token}/getWebhookInfo

```
{
"ok":true,
"result":{"url":"https://yoursubdomain.ngrok.io/api/update",
"has_custom_certificate":false,
"pending_update_count":0,
"max_connections":40}
}

###  Run bot local
Теперь вы можете запустить бота в локальном экземпляре.
