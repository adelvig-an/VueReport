<template>
    <div class="row">
        <div class="col">
            <h5>Организация</h5>
        </div>
    </div>
    <div class="row align-items-center">
        <div class="col-md-2">
            Наименование
        </div>
        <div class="col">
            <label class="form-lable" style="font-size:9px">
                Поиск по названию, ИНН или адресу
            </label>
            <input class="form-control" type="text" />
        </div>
    </div>
    <div class="row">
        <div class="col-md-4 offset-md-2">
            <label class="form-lable">
                ИНН
            </label>
            <input class="form-control" type="text" />
        </div>
        <div class="col-md-4">
            <label class="form-lable">
                КПП
            </label>
            <input class="form-control" type="text" />
        </div>
    </div>
    <div class="row">
        <div class="col-md-4 offset-md-2">
            <label class="form-lable">
                ОГРН
            </label>
            <input class="form-control" type="text" />
        </div>
        <div class="col-md-4">
            <label class="form-lable">
                Дата регистрации
            </label>
            <input class="form-control" type="date" />
        </div>
    </div>
    <div class="row">
        <div class="col">
            <h6>Руководитель организации</h6>
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

    <div class="row align-items-center">
        <div class="col-md-2">
            Должность
        </div>
        <div class="col">
            <input class="form-control" type="text" />
        </div>
    </div>

    <div class="row">
        <div class="col-md-2">
            Действующий на основании
        </div>
        <div class="col">
            <select class="form-select" v-model="isSelected" style="width:100%">
                <option value="1">Устава</option>
                <option value="2">Доверенности</option>
                <option value="3">Закона</option>
            </select>
            <div class="row" v-show="isSelected === '2'">
                <div class="col">
                    <label class="form-lable">
                        Номер доверенности
                    </label>
                    <input type="text" class="form-control" />
                </div>
                <div class="col">
                    <label class="form-lable">
                        Дата доверения
                    </label>
                    <input type="date" class="form-control" />
                </div>
                <div class="col">
                    <label class="form-lable">
                        Дата окончания
                    </label>
                    <input type="date" class="form-control" />
                </div>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col">
            <h6>Банковские реквизиты</h6>
        </div>
    </div>
    <div class="row">
        <div class="col-2">
            <label class="form-lable">
                БИК
            </label>
            <input type="text" class="form-control" />
        </div>
        <div class="col">
            <label class="form-lable">
                Наименование
            </label>
            <input type="text" class="form-control" />
        </div>
    </div>
    <div class="row">
        <div class="col">
            <label class="form-lable">
                Расчетный счет
            </label>
            <input type="text" class="form-control" />
        </div>
        <div class="col">
            <label class="form-lable">
                Корреспондентский счет
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
            <input class="form-check-input" type="checkbox" v-model="isAddressMatch" id="address-match">
            <label class="form-check-label" for="address-match">
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
                isAddressMatch: false,
                isSelected: '1'
                }
        }
    }
</script>