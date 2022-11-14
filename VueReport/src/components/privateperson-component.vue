<template>
    <div class="row">
        <div class="col">
            <h5>Частное лицо</h5>
        </div>
    </div>
    <div class="row">
        <div class="col">
            <label class="form-lable">
                Фамилия
            </label>
            <input type="text" class="form-control" />
        </div>
        <div class="col">
            <label class="form-lable">
                Имя
            </label>
            <input type="text" class="form-control" />
        </div>
        <div class="col">
            <label class="form-lable">
                Отчество
            </label>
            <input type="text" class="form-control" />
        </div>
    </div>
    <div class="row">
        <div class="col">
            <h6>Паспортные данные</h6>
        </div>
    </div>
    <div class="row">
        <div class="col">
            <label class="form-lable">
                Серия
            </label>
            <input type="text" class="form-control" />
        </div>
        <div class="col">
            <label class="form-lable">
                Номер
            </label>
            <input type="text" class="form-control" />
        </div>
        <div class="col">
            <label class="form-lable">
                Дата выдачи
            </label>
            <input type="date" class="form-control" />
        </div>
    </div>
    <div class="row">
        <div class="col">
            <label class="form-lable">
                Кем выдан
            </label>
            <input type="text" class="form-control" />
        </div>
        <div class="col-3">
            <label class="form-lable">
                Код подразделения
            </label>
            <input type="text" class="form-control" />
        </div>
    </div>
    <div class="row">
        <div class="col">
            <label class="form-lable">
                Адрес регистрации
            </label>
            <input type="text" class="form-control" />
        </div>
    </div>
    <div class="row">
        <div class="col">
            <input class="form-check-input" type="checkbox" v-model="isAddressMatch" id="flexCheckDefault">
            <label class="form-check-label" for="flexCheckDefault">
                Адрес фактический совподает с адресом регистрации
            </label>
        </div>
    </div>
    <div class="row">
        <div class="col">
            <label class="form-lable">
                Адрес фактический
            </label>
            <input type="text" class="form-control" :disabled="isAddressMatch" />
        </div>
    </div>
</template>

<script>
    export default {
        name: 'organization-component',
        data() {
            return {
                isAddressMatch: false
                }
        }
    }
</script>