<template>
    <div class="container">
        <div class="row">
            <div class="col-md-6">
                <lable>
                    Введите email:
                    <input type="email" :value="email" @input="emailInput($event.target.value)" />
                </lable>
            </div>
            <div class="col-md-6">email: {{ email }}</div>
            <div class="col-md-6">
                <label>
                    Введите пароль:
                    <input type="password" :value="password" @input="passwordInput($event.target.value)" />
                </label>
            </div>
            <div class="col-md-6">Test: {{ isCustomer }}</div>
            <div class="col-md-6">
                <div class="btn-group" role="group">
                    <input type="radio" value="true" name="radioCastomer" v-model="isCustomer" id="PrivatePerson"
                           class="btn-check" />
                    <label for="PrivatePerson" class="btn btn-outline-primary">Частное лицо</label>
                    <input type="radio" value="false" name="radioCastomer" v-model="isCustomer" id="Organization"
                           class="btn-check" />
                    <label for="Organization" class="btn btn-outline-primary">Организация</label>
                </div>
            </div>
            <div>
                <div class="col">
                    <h5 v-if="isCustomer === 'true'">Частное лицо</h5>
                    <h5 v-else>Организация</h5>
                </div>
            </div>
        </div>
        <div class="row text-center">
            <div class="col-md-2 block-1">.md-2</div>
            <div class="col-md-2 block-2">.md-2</div>
            <div class="col-md-2 block-3">.md-2</div>
            <div class="col-md-2 block-4">.md-2</div>
            <div class="col-md-2 block-4">.md-2</div>
            <div class="col-md-2 block-4">.md-2</div>
        </div>
        <div class="row text-center">
            <!-- Кнопка-триггер модального окна -->
            <div class="col-md-2 block-1">
                <a class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#exampleModal">Модальное окно</a>
            </div>
            <!-- Модальное окно -->
            <div class="modal fade" id="exampleModal" tabindex="-1" data-bs-keyboard="false" data-bs-backdrop="static" aria-labelledby="exampleModalLabel" aria-hidden="true">
                <div class="modal-dialog">
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Закрыть"></button>
                        </div>
                        <div class="modal-body">
                            ...
                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Закрыть</button>
                            <button type="button" class="btn btn-primary">Сохранить изменения</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
export default {
    name: 'authorization-component',
    data() {
        return {
            email: 'mymail@mail.ru',
            password: '12345678',
            isCustomer: false
        }
    },
    methods: {
        emailInput(value) {
            this.email = value
        },
        passwordInput(value) {
            this.password = value
        }
    }
}
</script>