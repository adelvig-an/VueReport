<template>
    <div class="content">
        <div class="container">
            <div class="row">
                <div class="col-md-6">
                    <lable>
                        Введите login:
                        <input type="text" v-model="login" />
                    </lable>
                </div>
                <div class="col-md-6">login: {{ login }}</div>
                <div class="col-md-6">
                    <label>
                        Введите пароль:
                        <input type="password" v-model="password" />
                    </label>
                </div>
                <div class="col-md-6">password: {{ password }}</div>
            </div>
        </div>
    </div>
    
</template>

<script lang="js">

    export default {
        name: 'test-component',
        data() {
            return {
                login: '',
                password: '',

            }
        },
        created() {
            this.fetchData();
        },
        watch:
        {
            '$route': 'fetchData'
        },
        methods: {
            fetchData() {

                fetch('user')
                    .then(r => r.json())
                    .then(json => {
                        this.login = json.login;
                        this.password = json.password;
                        return;
                    })
            }
        },
    }
</script>