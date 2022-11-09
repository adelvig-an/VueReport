<template>
    <div class="root">
        <lable>
            Введите email:
            <input type="email" v-bind:value="email" />
        </lable>
        <label>
            Введите пароль:
            <input type="password" v-bind:value="password" />
        </label>
    </div>
</template>

<script>
    export default {
        name: 'authorization-component',
        data() {
            return {
                email: 'mail@mail.ru',
                password: '12345678'
            }
        }
    }
</script>