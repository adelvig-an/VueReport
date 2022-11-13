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
</div>

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